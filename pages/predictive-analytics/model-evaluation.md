# Evaluating a model
## Evaluation metrics 
In all of the linear regression notebooks I use the MSE (Mean Squared Error) and R^2 (R squared) metrics. 
MSE gives an average of the squared errors (difference between estimated and actual value). R^2 is the proportion of the variance for a target variable that is explained by independent variable(s). Retrospectively, MSE might not have been a good metric to use for evaluation, so in the future I would change this to RMSE. 

## Cross validation
All of the linear regression models have used the "*train_test_split*" function from *Scikit* to split the data in training and validation sets. Out of the 25 total respondents, 22 respondents were splitted via this function. For training we used 80% of the data and 20% for validation. Also, 3 respondents were seperated at the start to be used as test set. 

Cross validation scores of "*linear_regression_XYZ_MET-*[ACTIVITY]*-new*" notebooks:
| **Activity** | **MSE** | **R^2** |
|-|-|-|
| Walking | 0.38 | 0.58 |
| Running | 3.19 | 0.51 |
| Cycling light | 0.93 | 0.11 |
| Cycling heavy | 0.58 | 0.41 |

## 5-fold cross validation
In addition, because our data set is not that large I applied 5-fold cross validation in any of the "*linear_regression_XYZ_MET-*[ACTIVITY]*-new*" notebooks. 5-fold cross validation scores are in most cases drastically worse than the cross validation scores.

5-fold cross validation scores of "*linear_regression_XYZ_MET-*[ACTIVITY]*-new*" notebooks:
| **Activity** | **Mean MSE** | **Mean R^2** |
|-|-|-|
| Walking | -0.59 +/- 0.25 | -0.03 +/- 0.50 |
| Running | -3.49 +/- 0.83 | 0.33 +/- 0.14 |
| Cycling light | -1.30 +/- 0.47 | 0.11 +/- 0.16 |
| Cycling heavy | -0.83 +/- 0.31 | 0.38 +/- 0.20 |

## Test set 
Test set scores of "*linear_regression_XYZ_MET-*[ACTIVITY]*-new*" notebooks:
| **Activity** | **MSE** | **R^2** |
|-|-|-|
| Walking | 0.42 | 0.41 |
| Running | 4.95 | 0.17 |
| Cycling light | 4.79 | -1.57 |
| Cycling heavy | 3.32 | -0.16 |


## Conclusion
Based on these scores and knowing our data set I think there are two things going on. 
1. The multivariate linear regression models are underfitting, probably because it is too simple of a model for this data set.
2. The data set is too small and unrepresentative which makes training a good model difficult. 