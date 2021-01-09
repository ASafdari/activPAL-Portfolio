# Conclusions

In week 18 of the project we performed the first version of the final presentation. I wrote and presented the conclusion in this presentation.

## Conclusion activity classification
We created an application that executes the classification model on week data of a respondent. Based on this result I think the activity classification output contains many false positives for sitting and standing activities. In that case of sitting I think that because in the nightime when a person should be lying down to sleep it is classified as sitting. In the case of standing it is because for example in the nighttime a person does not typically stand up for half an hour without walking prior or after that, which the data does show. When comparing the activity classification output of the same day from our software with the software of activPAL called palANALYSIS, it is also clear that our version predicts more standing activities than palANALYSIS. The problem with this conclusion is that there is no concrete ground truth for the week data of a respondent. In theory the output of our software is possible. 

[Our application output](evidence/application-output.png)

[palANALYSIS output](evidence/palANALYSIS-output.jpeg)

## Conclusion regression models
Based on the metrics of the regression models I think the models are overfitting. Mainly because our dataset is too little. 

## General conclusion
In the end, I do not think we can accurately predict whether a person has performed at least 150 minutes of moderate intense physical activity with the current dataset used by the regression models. 


[Presentation week 18](/evidence/presentations/08-01-2021-external-presentation-week-18.pdf)