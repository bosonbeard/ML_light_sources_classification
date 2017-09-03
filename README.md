## ML_ spectrum_classification

Данный репозиторий является дополнительным материалом к статье на портале Habrahabr – https://habrahabr.ru/post/337040/
демонстрирующим примеры классификации спектров излучения источников искусственного и естественного света представлены 
  
Внимание! Изложенные ниже методы и данные на основании, которых проводится классификация, собраны на основании материалов, размещенных пользователями в общем доступе на портале https://spectralworkbench.org/  и не предполагают научной достоверности.
Учитывая возможные ошибки вызванные техническими и «человеческими» факторами рекомендуется применение набора данных исключительно в демонстрационных целях. 


Material on the machine classification of the emission spectra of lamps and sun.
Complements Article - https://habrahabr.ru/post/337040/
Materials may contain errors, not recommended for serious research.
Spectrum source https://spectralworkbench.org/  
P.S. English text from google translate :)

## Описание данных (Data description)
Набор данных состоит из тестовой и обучающей выборки, описывающей спектры источников света.  
Спектральные характеристики разбиты на 301 признак где значение признака соответствует длине волны в спектре.    
Значение признака – условная мощность излучения.   
Поле label содержит метку источника света:  
0-	Светодиодная лампа (белый свет от WW/CW/NW/RGB светодиодов или их комбинации);  
1-	Люминесцентная лампа (компактная или трубчатая);  
2-	Дневной свет (солнце, небо, или их комбинация);  
train.csv – обучающая выборка;  
test.csv – контрольная выборка;  
train_names csv , test_names.csv– имена источников спектра для train и test соответственно.
Просмотреть исходный спектр можно по адресу :
https://spectralworkbench.org/spectrums/XXXX  
где: XXXX- имя спектра в файле.
Например: https://spectralworkbench.org/spectrums/9740


The data set consists of a test and training sample that describes the spectrum of light sources.
Spectral characteristics are divided into 301 features where the value of the characteristic corresponds to the wavelength in the spectrum.
The value of the characteristic is the emission power.  
The label field contains the light source label:  
0- LED lamp (white light from WW / CW / NW / RGB LEDs or their combination);  
1- Fluorescent lamp (compact or tube);  
2- Daylight (sun, sky, or or their combination);  
train.csv - training sample, test.csv - testing sample;  
train names csv, test_names.csv - filenames of the spectrum sources for train and test, respectively.
View the original spectrum can be found at:
https://spectralworkbench.org/spectrums/XXXX  
where: XXXX is the name of the spectrum in the file.
For example: https://spectralworkbench.org/spectrums/9740


## Пример машинного обучения (Example of machine learning)

Базовые модели машинного обучения представлены в файле spectrum_classify_for_habrahabr.ipynb


Base models are presented in the  spectrum_classify_for_habrahabr.ipynb