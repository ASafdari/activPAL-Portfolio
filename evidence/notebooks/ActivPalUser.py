class ActivPalUser:
  def __init__(self, gender, estimated_level, is_sporter, length_cm, weight_kg, age_category, meets_balance_guidelines, meets_activity_guidelines):
    self.gender = gender
    self.estimated_level = estimated_level
    self.is_sporter = is_sporter
    self.length_cm = length_cm
    self.weight_kg = weight_kg
    self.bmi =  self.weight_kg / ((self.length_cm / 100) ** 2)
    self.age_category = age_category
    self.meets_balance_guidelines = meets_balance_guidelines
    self.meets_activity_guidelines = meets_activity_guidelines
    
