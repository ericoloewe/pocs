import { FirstPipePipe } from './first-pipe.pipe';

describe('FirstPipePipe', () => {
  it('create an instance', () => {
    const pipe = new FirstPipePipe();
    expect(pipe).toBeTruthy();
  });
});
