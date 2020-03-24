import 'package:flutter/foundation.dart';
import 'package:flutter/material.dart';

import 'drawer.dart';

class ChipsPage extends StatelessWidget {
  final String title;
  int _value;

  ChipsPage({Key key, this.title}) : super(key: key);

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        // Here we take the value from the MyHomePage object that was created by
        // the App.build method, and use it to set our appbar title.
        title: Text(this.title),
      ),
      body: Wrap(
        children: List<Widget>.generate(
          3,
          (int index) {
            return ChoiceChip(
              label: Text('Item $index'),
              selected: _value == index,
              onSelected: (bool selected) {
                print(selected);
              },
            );
          },
        ).toList(),
      ),
      drawer: MyDrawer(),
    );
  }
}
