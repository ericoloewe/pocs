from sklearn.neighbors import KNeighborsClassifier
import csv

tsv_file = open(
    "D:\\Temp\\dataset-music\\lastfm-dataset-1K\\userid-timestamp-artid-artname-traid-traname.tsv", encoding="utf8")

csv_file = open(
    "D:\\Temp\\dataset-music\\lastfm-dataset-1K\\userid-timestamp-artid-artname-traid-traname_parsed.csv", encoding="utf8", mode='w')

reader = csv.reader(tsv_file, delimiter="\t")

writer = csv.writer(csv_file, delimiter=',', quotechar='"',
                    quoting=csv.QUOTE_MINIMAL)

for row in reader:
    row.remove('\n')

    if row[0] == "user_000101":
        break

    writer.writerow(row)

knn = KNeighborsClassifier(n_neighbors=3)

# knn.fit(features, classes)

# knn.predict(new_object)

print("Hello world")

tsv_file.close()
csv_file.close()
