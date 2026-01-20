namespace Multimedialny_przewodnik_po_Uczelni.Services
{
    public class UserSessionService
    {
        public int? CurrentNodeId { get; set; }
        public string? CurrentNodeName { get; set; }
        public bool IsHighContrast { get; set; } = false;
        public bool IsWheelchairMode { get; set; } = false;

        public event Action? OnChange;

        public void ToggleContrast()
        {
            IsHighContrast = !IsHighContrast;
            NotifyStateChanged();
        }

        public void SetContrast(bool isHigh)
        {
            IsHighContrast = isHigh;
            NotifyStateChanged();
        }

        public void ToggleWheelchairMode()
        {
            IsWheelchairMode = !IsWheelchairMode;
            NotifyStateChanged();
        }
        private void NotifyStateChanged() => OnChange?.Invoke();
    }
}