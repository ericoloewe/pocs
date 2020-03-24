import 'package:flutter/material.dart';

class MyDrawer extends StatelessWidget {
  @override
  Widget build(BuildContext context) {
    return Drawer(
        child: ListView(
      padding: EdgeInsets.zero,
      children: <Widget>[
        DrawerHeader(
          decoration: BoxDecoration(
            color: Colors.blue,
          ),
          child: Text(
            'Drawer Header',
            style: TextStyle(
              color: Colors.white,
              fontSize: 24,
            ),
          ),
        ),
        ListTile(
          leading: Icon(Icons.message),
          title: Text('Input'),
          onTap: () => Navigator.pushNamed(context, '/input'),
        ),
        ListTile(
          leading: Icon(Icons.cake),
          title: Text('Chips'),
          onTap: () => print("Chips"),
        ),
        ListTile(
          leading: Icon(Icons.slideshow),
          title: Text('Slider'),
          onTap: () => print("Slider"),
        ),
        ListTile(
          leading: Icon(Icons.card_giftcard),
          title: Text('Card'),
          onTap: () => print("Card"),
        ),
        ListTile(
          leading: Icon(Icons.account_circle),
          title: Text('Select'),
          onTap: () => print("Select"),
        ),
      ],
    ));
  }
}
