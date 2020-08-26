/**
 * App tests
 */
import React from 'react';
import renderer from 'react-test-renderer';
import { HomeScreen } from '../home';

it('renders correctly with defaults', () => {
  const button = renderer
    .create(<HomeScreen />)
    .toJSON();

  expect(button).toMatchSnapshot();
});