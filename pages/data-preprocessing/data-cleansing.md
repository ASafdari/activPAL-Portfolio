# Data cleansing
In communication with Annemieke the following issues became clear:
* BMR006 mounted the activPAL horizontally
* BMR027 data files were lost
* BMR035 activPAL stopped working on the first day
* BMR051 activPAL stopped after 4 days

From my own investigation in the data files the following issues became clear:
* BMR025 has no Vyntus file
* BMR028 did not get the files, but the respondent code is in the list of respondents
* BMR029 did not get the files, but the respondent code is in the list of respondents
* BMR051 has no Vyntus file
* BMR060 Vyntus file is empty
* BMR099 Vyntus file does not contain data for walking and running activities
* BMR100 timestamps of activities from the activity file are not existent in the activPAL file 
* All Vyntus files do not contain the timestamps for stairwalking and jumping activities

To conclude, respondents 25, 51 and 60 could not be used for model training since the Vyntus files are missing but could've been used in the test set. Respondents 100 could not be used for training since the timestamps of the activities are not in the activPAl file but could've been used in the test set. Respondents 28 and 29 could not be used at all since the data files went missing. 