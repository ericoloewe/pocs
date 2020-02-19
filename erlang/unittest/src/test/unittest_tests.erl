-module(unittest_tests).

-include_lib("eunit/include/eunit.hrl").
-include_lib("eunit/include/eunit.hrl").

unittest_test() ->
  [{"Should not break X",  fun first_test/0}].

first_test() ->
  ?assert(1 + 1 =:= 2).