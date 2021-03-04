import { TogetherTemplatePage } from './app.po';

describe('Together App', function() {
  let page: TogetherTemplatePage;

  beforeEach(() => {
    page = new TogetherTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
