## Classification of luminaries by LIDC   
  
Данный репозиторий является дополнительным материалом к статьяе на портале Habrahabr https://habrahabr.ru/post/338124/   
демонстрирующим пример классификации источников искусственного и естественного света по КСС.  
  
  Набор данных состоит из тестовой и обучающей выборки, описывающей кривые силы света светильников (КСС).
КСС разбиты на 19 признаков где значение признака соответствует силе света светильника в направлении соответствующего полярного угла. Все данные взяты относительно азимутального угла - 0 градусов. Значение признака – условная мощность излучения.
Поле label содержит метку источника света:
Типы КСС взяты в соответствии с ГОСТ Р 54350-2011 1- Компактная КСС (Тип К);  
2- Глубокая КСС (Тип Г);  
3- Косинусная (Тип Д);  
4- Полу широкая (Тип Л);  
train.csv – обучающая выборка;  
train.csv – обучающая выборка;    
Также в таблице в столбце files находятся наименования светильников, если вы захотите
 сами проверить корректность распределения силы света (https://www.ltcompany.com/ru/products/types/indoor-luminaires/).
В файле lidc_classify_for_habrahabr.pynb содержится пример реализации машинной классификации светильников по КСС  
с применением Python библиотеки scikit-learn  
 
The data set consists of a test and training sample describing the luminous intensity curves (KSS).  
 KCC divided into 19 features where the value of the characteristic corresponds to the light   
 intensity of the lamp in the direction of the corresponding polar angle. All data are taken  
 for the azimuth angle of 0 degrees. Significance value - light power. The label field contains   
 the light source label: Types of LIDC are taken in accordance with GOST R 54350-2011 
 1- Compact LIDC;  
 2- Deep LIDC;  
 3- Cosine LIDC;  
 4- Semi-wide LIDC;  
 train.csv - training sample;  
 train.csv - training sample;  
 The lidc_classify_for_habrahabr.pynb file contains an example of implementing a machine classification 
 of fixtures using python library scikit-learn  
 
 Also in the table in the files column are the names of the luminaires,  
 if you want to check the correctness of the distribution of light intensity   
 yourself. (https://www.ltcompany.com/ru/products/types/indoor-luminaires/)
