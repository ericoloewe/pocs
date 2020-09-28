#!/bin/sh

cd kafka_2.13-2.6.0

echo Running zookeeper-server-start
bin/zookeeper-server-start.sh config/zookeeper.properties &

echo Running kafka-server-start &
exec bin/kafka-server-start.sh config/server.properties