import { LibraryAppTemplatePage } from './app.po';

describe('LibraryApp App', function() {
  let page: LibraryAppTemplatePage;

  beforeEach(() => {
    page = new LibraryAppTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
