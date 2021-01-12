from entity.ActivPalUser import ActivPalUser
from helpers.PandasHelper import read_csv_respondents
import pandas as pd


class ActivPalUserFactory:
    def __init__(self):
        self.mapping_yes_no = {'ja': 1, 'nee': 0}
        self.mapping_gender = {'man': 1, 'vrouw': 0}
        self.mapping_estimated_level = {'actief': 1, 'niet actief': 0}
        self.mapping_age_categories = {
            '15-19': 0, '20-24': 1, '25-29': 2, '30-34': 3,
            '35-39': 4, '40-44': 5, '45-49': 6, '50-54': 7,
            '55-59': 8, '60-64': 9, '65-69': 10, '70-74': 11, '75-79': 12
        }

    def create_from_respondent_code(self, code):
        resp_number = self.get_respondent_number_by_code(code)

        respondents_csv = read_csv_respondents()
        row = respondents_csv.loc[resp_number]

        return self.create_from_respondents_row(row, True)

    def get_respondent_number_by_code(self, code):
        if ('BMR0' in code):
            return int(code.replace('BMR0', ''))

        elif ('BMR' in code):
            return int(code.replace('BMR', ''))

    def create_from_respondents_row(self, row, clean_values=False):
        is_sporter = row['sporter']
        length_cm = row['lengte']
        weight_kg = row['gewicht']

        if clean_values:
            row_dict = row.to_dict()

            gender = self.mapping_gender.get(row_dict.get('geslacht'))
            estimated_level = self.mapping_estimated_level.get(row_dict.get('ingeschat niveau'))
            age_category = self.mapping_age_categories.get(row_dict.get('leeftijdscategorie'))
            meets_balance_guidelines = self.mapping_yes_no.get(row_dict.get('voldoet aan richtlijn balansoefeningen'))
            meets_activity_guidelines = self.mapping_yes_no.get(row_dict.get('voldoet aan beweegrichtlijn 2nee17'))

            return ActivPalUser(gender, estimated_level, is_sporter, length_cm, weight_kg, age_category,
                                meets_balance_guidelines, meets_activity_guidelines)

        else:
            gender = row['geslacht']
            estimated_level = row['ingeschat niveau']
            age_category = row['leeftijdscategorie']
            meets_balance_guidelines = row['voldoet aan richtlijn balansoefeningen']
            meets_activity_guidelines = row['voldoet aan beweegrichtlijn 2nee17']

            return ActivPalUser(gender, estimated_level, is_sporter, length_cm, weight_kg, age_category,
                                meets_balance_guidelines, meets_activity_guidelines)
