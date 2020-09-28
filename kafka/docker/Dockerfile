FROM openjdk:8

COPY / App/

WORKDIR /App

EXPOSE 9092
EXPOSE 2181

ENTRYPOINT ["./kafka-run.sh"]