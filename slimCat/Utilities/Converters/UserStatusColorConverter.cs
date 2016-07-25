namespace slimCat.Utilities
{
	using System.Windows.Media;
	using Models;

	/// <summary>
	///     Converts StatusType into a SolidColorBrush.
	/// </summary>
	public sealed class UserStatusColorConverter : OneWayConverter
	{
		public override object Convert(object value, object parameter)
		{
			Color color;

			try
			{
				var status = (StatusType)value;

				switch (status)
				{
					case StatusType.Offline:
						color = Color.FromRgb(0, 0, 0);
						break;
					case StatusType.Online:
						color = Color.FromRgb(0, 0, 255);
						break;
					case StatusType.Away:
						color = Color.FromRgb(255, 255, 0);
						break;
					case StatusType.Busy:
						color = Color.FromRgb(255, 128, 0);
						break;
					case StatusType.Looking:
						color = Color.FromRgb(0, 255, 0);
						break;
					case StatusType.Idle:
						color = Color.FromRgb(128, 128, 128);
						break;
					case StatusType.Dnd:
						color = Color.FromRgb(255, 0, 0);
						break;
					case StatusType.Crown:
						color = Color.FromRgb(0, 255, 255);
						break;
					default:
						color = Color.FromRgb(255, 255, 255);
						break;
				}
			}
			catch
			{
				color = Color.FromRgb(255, 0, 255);
			}

			return new SolidColorBrush(color);
		}
	}
}