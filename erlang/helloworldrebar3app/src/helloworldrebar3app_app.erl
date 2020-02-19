%%%-------------------------------------------------------------------
%% @doc helloworldrebar3app public API
%% @end
%%%-------------------------------------------------------------------

-module(helloworldrebar3app_app).

-behaviour(application).

-export([start/2, stop/1]).

start(_StartType, _StartArgs) ->
    helloworldrebar3app_sup:start_link().

stop(_State) ->
    ok.

%% internal functions
