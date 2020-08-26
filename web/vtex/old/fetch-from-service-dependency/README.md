# Fetch from service dependency

This example shows how it is possible to decouple backend and frontend into two independent apps.

This way more thant one render app can consume the same service app, and the render app can consume more than one service app.

Note that this app depends on [vtex.serve-users-list](https://github.com/vtex-apps/service-getting-started/tree/master/examples/serve-users-list) as stated on the [Manifest](./manifest.json)