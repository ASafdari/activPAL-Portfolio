import pandas as pd
from scipy.stats import mode
from helpers import MathHelper


class MetRegressionDataPreparingUtils:
    def __init__(self):
        self.resample_rule = '60s'
        self.resample_aggregate = {'sum_mag_acc': 'sum', 'mean_speed': 'mean', 'activity': lambda a: mode(a)[0]}

    def prepare_data_frame(self, activpal_data_frame, activpal_user):
        prepared_df = pd.DataFrame(index=pd.to_datetime([]))

        # convert activpal dataframe x, y & z column values to g-force equivalent
        x_g = activpal_data_frame['x']
        y_g = activpal_data_frame['y']
        z_g = activpal_data_frame['z']

        # add activity
        prepared_df['activity'] = activpal_data_frame['activity']
        # add magnitude of acceleration to prepared dataframe
        prepared_df['sum_mag_acc'] = MathHelper.to_mag_acceleration(x_g, y_g, z_g)

        # add speed to prepared dataframe
        prepared_df['mean_speed'] = MathHelper.to_speed(x_g, y_g, z_g)

        # resample prepared dataframe to resample rule and aggregate resampling
        prepared_df = prepared_df.resample(self.resample_rule).agg(self.resample_aggregate)[:-1]

        # add personal user information to prepared data frame
        prepared_df['gender'] = activpal_user.gender
        prepared_df['estimated_level'] = activpal_user.estimated_level
        prepared_df['is_sporter'] = activpal_user.is_sporter
        prepared_df['length_cm'] = activpal_user.length_cm
        prepared_df['weight_kg'] = activpal_user.weight_kg
        prepared_df['bmi'] = activpal_user.bmi
        prepared_df['age_category'] = activpal_user.age_category
        prepared_df['meets_balance_guidelines'] = activpal_user.meets_balance_guidelines
        prepared_df['meets_activity_guidelines'] = activpal_user.meets_activity_guidelines

        return prepared_df
