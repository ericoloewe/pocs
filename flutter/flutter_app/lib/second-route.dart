import 'package:flutter/material.dart';
import 'package:flutter_app/playlist.dart';

import 'drawer.dart';

class SecondRoutePage extends StatefulWidget {
  SecondRoutePage({Key key, this.title}) : super(key: key);

  // This widget is the home page of your application. It is stateful, meaning
  // that it has a State object (defined below) that contains fields that affect
  // how it looks.

  // This class is the configuration for the state. It holds the values (in this
  // case the title) provided by the parent (in this case the App widget) and
  // used by the build method of the State. Fields in a Widget subclass are
  // always marked "final".

  final String title;

  @override
  _MyHomePageState createState() => _MyHomePageState();
}

class _MyHomePageState extends State<SecondRoutePage> {
  @override
  Widget build(BuildContext context) {
    // This method is rerun every time setState is called, for instance as done
    // by the _incrementCounter method above.
    //
    // The Flutter framework has been optimized to make rerunning build methods
    // fast, so that you can just rebuild anything that needs updating rather
    // than having to individually change instances of widgets.

    final Playlist playlist = ModalRoute.of(context).settings.arguments;

    return Scaffold(
      appBar: AppBar(
        // Here we take the value from the MyHomePage object that was created by
        // the App.build method, and use it to set our appbar title.
        title: Text(widget.title),
      ),
      body: Center(
          child: ListView(
        children: <Widget>[
          RaisedButton(
            onPressed: () {
              Navigator.pop(context);
            },
            child: Text('Go back!'),
          ),
          Text(playlist.title),
          Text(playlist.subtitle),
          Image.network(
              'https://flutter.github.io/assets-for-api-docs/assets/widgets/owl-2.jpg'),
        ],
      )),
      drawer: MyDrawer(),
    );
  }
}
