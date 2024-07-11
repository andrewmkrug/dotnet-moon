# dotnet moon repo - monorepo

## Setup 

1. Clone this repo
1. Install [proto](https://moonrepo.dev/docs/proto/install). 
1. Install all tools

```sh
proto use
```

1. Add `dotnet` to PATH env variable, only because of the implementation of the dotnet plugin.

```sh
echo 'export DOTNET_ROOT="$HOME/.dotnet"' >> ~/.zshrc
echo 'export PATH="$DOTNET_ROOT:$PATH"' >> ~/.zshrc
```

### Mac Setup on zsh

``` sh
brew install proto
source ~/.zshrc
proto use

echo 'export DOTNET_ROOT="$HOME/.dotnet"' >> ~/.zshrc
echo 'export PATH="$DOTNET_ROOT:$PATH"' >> ~/.zshrc
```

## General Use

| Task | Command |
| --- | --- |
| Run Affected Targets | `moon ci` |
