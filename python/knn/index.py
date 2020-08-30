from sklearn.neighbors import KNeighborsClassifier
from sklearn import preprocessing

# creating labelEncoder
le = preprocessing.LabelEncoder()

# Assigning features and label variables
# First Feature
felling = ['Feliz', 'Feliz', 'Feliz', 'Deprimido', 'Triste', 'Feliz', 'Triste',
           'Feliz', 'Ansioso', 'Triste', 'Aborrecido', 'Amoroso', 'Feliz', 'Triste']

# Second Feature
activity = ['Dirigindo', 'Lazer', 'Trabalhando', 'Trabalhando', 'Lazer', 'Dirigindo', 'Tomando banho',
           'Treinando', 'Jogando', 'Trabalhando', 'Trabalhando', 'Lazer', 'Lazer', 'Tomando banho']

# Third Feature
weather = ['Sunny', 'Sunny', 'Overcast', 'Rainy', 'Rainy', 'Rainy', 'Overcast',
           'Sunny', 'Sunny', 'Rainy', 'Sunny', 'Overcast', 'Overcast', 'Rainy']


# Label or target varible
genres = ['Eletronica', 'Funk', 'Funk', 'Folk', 'Rock', 'Eletronica', 'Country',
        'Eletronica', 'Eletronica', 'Sertanejo', 'Pop', 'Sertanejo', 'Pop', 'Rock']

# Converting string labels into numbers.
felling_encoded = le.fit_transform(felling)
activity_encoded = le.fit_transform(activity)
weather_encoded = le.fit_transform(weather)

print(felling_encoded)
print(activity_encoded)
print(weather_encoded)

label = le.fit_transform(genres)

print(label)

# combinig weather and temp into single listof tuples
features = list(zip(felling_encoded, activity_encoded, weather_encoded))

print(features)

model = KNeighborsClassifier(n_neighbors=3)

# Train the model using the training sets
model.fit(features, label)

# Predict Output
print(model.predict([[4, 2, 2]]))  # 4:Feliz, 2:Lazer, 2:Sunny
print(model.predict([[4, 4, 2]]))  # 4:Feliz, 4:Trabalhando, 2:Sunny
print(model.predict([[4, 2, 1]]))  # 4:Feliz, 2:Lazer, 1:Rainy
print(model.predict([[4, 4, 1]]))  # 4:Feliz, 4:Trabalhando, 1:Rainy
print(model.predict([[5, 4, 1]]))  # 5:Triste, 4:Trabalhando, 1:Rainy
