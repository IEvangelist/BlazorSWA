using BlazorApp.Shared;

public class StateContainer
{
  private LinkBundle savedLinkBundle = new LinkBundle();

  public LinkBundle LinkBundle
  {
    get => savedLinkBundle ??= new LinkBundle();
    set
    {
      savedLinkBundle = value;
      NotifyStateChanged();
    }
  }

  public event Action? OnChange;

  private void NotifyStateChanged() => OnChange?.Invoke();
}