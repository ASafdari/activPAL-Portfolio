What I did for ActivPal minor:
* Data Camp
* research, article: how to calculate exercise energy expendure, on traininglab
* research, paper: MET Calculations from On-Body Accelerometers for Exergaming Movements
* Did the first internal presentation
* first note-taker
* second scrummaster
* created pandashelper containing reusable helper methods
* created datetimehelper containing reusable helper methods
* created mathhelper containing reusable helper methods
* created and worked on plot_basic_activities
    - did correct datetime formatting
    - reading in dataframes with correct datetimes
    - resampling df to 5s mean
    - plotting mag acc mean bicycling light
    - plotting mag acc mean biclycling intense
    - plotting mag acc mean standing
    - plotting mag acc mean sitting
    - plotting mag acc mean walking
    - plotting mag acc mean running
    - plotting mag acc mean stairwalking
    - plotting mag acc mean jumping
    - created get_activity_in_df helper method
* worked on & finished create_csv_with_activity_labels_per_correspondent with Colin
* Fixed bugs in read_csv_activpal20_with_activiteiten() 
* Created Plot_walking_for_correspondents
* Helped create the first external presentation
* Converted plots in Plot_basic_activities to just only X, Y, Z values for brief time windows
* Created removing_outliers with Colin (we found out through teacher outliers didn't work as we thought, they're probably not outliers)
    - most of our work was a bit faulty because of wrong interpretation of x, y z
* Read official activpal documentation to try to understand the X, Y, Z, Acceleration volume and orientation columns
* Created convert_value_to_acceleration helper method in math_helper
* Finished linear_regression_xyz_met with conclusion there is no linear correlation
* Worked on non_linear_regression_xyz_met, did not get any clear answers
* Read paper: Measurement of Physical Activity Using Accelerometers, got a lot of new insights. linear regression with met is possible!
* Finished linear regression with conclusion: there is a regression between mean MET in a minute and summation of magnitude of acceleration in a minute.
* Created reusable functions in linear_regression_met_xyz
* Calculated correlation for all (compatible) respondents
* Created helper method: calculate_bmi
* Added BMI to multivariate regression MET
* fixed time window issue for linear regression MET
* Added gender to multivariate linear regression MET
* Did the second external presentation
* Did data cleaning, found out low pearson correlation for 32, 43 is because of old age (70+) and 99 because of activity timestamps not in vyntus and many more, check note
* refactored get_regression_df and get_vyntus_df
* created method: get_correspondent_number()
* Added age category to multivariate linear regression MET
* Added sporter to multivariate linear regression MET
* Added exercise_guideline_complianceto multivariate linear regression MET
* Added does_muscle_bone_exercises to multivariate linear regression MET
* Added balance_guideline_compliance to multivariate linear regression MET
* Rewrote research questions and sub questions based on own perspective and feedback from sir * Andrioli (iteration 2)
* Created ActivityRecognitionDataPreparingUtils
* Created MetRegressionDataPreparingUtils
* Created DataPreparingUtilFactory
* Created ActivPalUser
* Created ActivPalUserFactory
* Did internal presentation 23-11-2020
* Did Dimensionality Reduction on linear regression MET:
    - Drop missing values
    - Drop variables with zero variation
    - Drop very low correlation variables
    - https://www.youtube.com/watch?v=YaKMeAlHgqQ&ab_channel=DataSchool
* Program: weekdata: predict met value
* Paper: Introduction v1
* Paper: Introduction v2
* Paper: Introduction v4
* Paper: Methods: international rec PA
* Paper: Results: international rec PA
* Paper: Method: adnan geholpen met activity classification 
* Presentatie #15 gemaakt
* Presentatie #15 gehouden
* data-preprocessing_respondenten gemaakt