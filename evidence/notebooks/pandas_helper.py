import pandas as pd
from helpers import datetime_helper
from datetime import datetime

path_prefix = '../../data/'

def read_csv_activpal20(correspondent):
    file_path = path_prefix + correspondent + '/activpal20.csv'
    return pd.read_csv(file_path, delimiter=';', index_col=0, parse_dates=['pal_time'], date_parser=datetime_helper.timestamp_to_datetime)

# Toevoegen activiteiten labels - Matthew 9/23/2020
def read_csv_activpal20_with_activiteiten(correspondent):
    file_path = path_prefix + correspondent + '/activpal20_with_activities.csv'
    return pd.read_csv(file_path, index_col=0, parse_dates=True)

def read_csv_activpal1_15(correspondent):
    file_path = path_prefix + correspondent + '/activpal1_15.csv'
    return pd.read_csv(file_path, delimiter=';', index_col=0, parse_dates=True, date_parser=datetime_helper.timestamp_to_datetime)

def read_csv_activiteiten(correspondent):
    file_path = path_prefix + correspondent + '/activiteiten.csv'
    return pd.read_csv(file_path, delimiter=';', index_col=0)

def read_csv_weekdata(correspondent):
    file_path = path_prefix + correspondent + '/weekdata.csv'
    return pd.read_csv(file_path, delimiter=';', parse_dates=True)

def read_csv_vyntus(correspondent):
    file_path = path_prefix + correspondent + '/vyntus.csv'
    return pd.read_csv(file_path, delimiter= ';',  index_col=0, parse_dates=True, date_parser=datetime_helper.timestamp_to_datetime)

def get_timestamp(timestamp):
    return timestamp.split(',')[0]

def get_activity_in_df(df, correspondent, activity):
    activities_df = read_csv_activiteiten(correspondent)
    activity_df = activities_df.loc[activity, :]
    return df.loc[activity_df['start'] : activity_df['stop']]

# defined read_csv_respodents() function 04-10-2020
def read_csv_respondents():
    file_path = path_prefix + 'respondenten.csv'
    return pd.read_csv(file_path, delimiter=',', index_col=0)

def read_csv_vyntus(correspondent):
    file_path = path_prefix + correspondent + '/vyntus.csv'
    return pd.read_csv(file_path, delimiter=';', index_col=0, parse_dates=True, date_parser=datetime_helper.timestamp_to_datetime)

# Adnan Akbas - 27/10/2020
def read_activpal_20_diceface(correspondent):
    dateparse = lambda x: datetime.strptime(x, '%Y-%m-%d %H:%M:%S:%f')
    
    
    file_path = path_prefix + correspondent + '/activpal_20_diceface.csv'
    return pd.read_csv(file_path, delimiter=',', index_col=0, parse_dates=True, date_parser=dateparse)

def read_csv_respondents_speed():
    file_path = path_prefix + 'respondenten_met_snelheid.csv'
    return pd.read_csv(file_path, delimiter=',', index_col=0)

# Ali
def read_csv_respondents_cleaned():
    file_path = path_prefix + 'respondents-cleaned.csv'
    return pd.read_csv(file_path, delimiter=',', index_col=0)
