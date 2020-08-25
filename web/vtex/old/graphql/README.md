# hello-graphql

### Quick start

```
npm i -g vtex
vtex link --verbose
```

Navigate to `yourstore.myvtex.com/_v/graphiqlServer`

Type the following query in the left side:

```
query {
  myProduct {
    name
    length
  }
  status(status: 200)
}
```

Hit `ctrl+enter` or `cmd+enter`.
