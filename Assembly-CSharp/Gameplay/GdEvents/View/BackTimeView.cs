using System;
using Gameplay.GdEvents.Model;
using Gameplay.GdEvents.Model.Categories;
using Il2CppDummyDll;
using TMPro;
using UI;
using UnityEngine;

namespace Gameplay.GdEvents.View
{
	// Token: 0x0200071D RID: 1821
	[Token(Token = "0x200071D")]
	public class BackTimeView : MonoBehaviour, IDisposable
	{
		// Token: 0x06002B92 RID: 11154 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B92")]
		[Address(RVA = "0x7C29", Offset = "0x7C29", VA = "0x7C29")]
		private void OnDisable()
		{
		}

		// Token: 0x06002B93 RID: 11155 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B93")]
		[Address(RVA = "0x7C2A", Offset = "0x7C2A", VA = "0x7C2A")]
		private void OnDestroy()
		{
		}

		// Token: 0x06002B94 RID: 11156 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B94")]
		[Address(RVA = "0x7C2B", Offset = "0x7C2B", VA = "0x7C2B")]
		private void Start()
		{
		}

		// Token: 0x06002B95 RID: 11157 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6002B95")]
		[Address(RVA = "0x7C2C", Offset = "0x7C2C", VA = "0x7C2C")]
		private string FormatBackTimeCallback(float value)
		{
			return null;
		}

		// Token: 0x06002B96 RID: 11158 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B96")]
		[Address(RVA = "0x7C2D", Offset = "0x7C2D", VA = "0x7C2D")]
		public void Init(GdEventData data, TimerStrings timerStrings)
		{
		}

		// Token: 0x06002B97 RID: 11159 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B97")]
		[Address(RVA = "0x7C2E", Offset = "0x7C2E", VA = "0x7C2E")]
		public void Init(GdEventData data)
		{
		}

		// Token: 0x1700084E RID: 2126
		// (get) Token: 0x06002B98 RID: 11160 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06002B99 RID: 11161 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700084E")]
		public GdEventData Data
		{
			[Token(Token = "0x6002B98")]
			[Address(RVA = "0x7C2F", Offset = "0x7C2F", VA = "0x7C2F")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002B99")]
			[Address(RVA = "0x7C30", Offset = "0x7C30", VA = "0x7C30")]
			private set
			{
			}
		}

		// Token: 0x06002B9A RID: 11162 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B9A")]
		[Address(RVA = "0x7C31", Offset = "0x7C31", VA = "0x7C31")]
		private void HandleDataChanged(GdEventData data)
		{
		}

		// Token: 0x06002B9B RID: 11163 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B9B")]
		[Address(RVA = "0x7C32", Offset = "0x7C32", VA = "0x7C32")]
		private void ValidateState(GdEventData data)
		{
		}

		// Token: 0x06002B9C RID: 11164 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B9C")]
		[Address(RVA = "0x7C33", Offset = "0x7C33", VA = "0x7C33", Slot = "4")]
		public void Dispose()
		{
		}

		// Token: 0x06002B9D RID: 11165 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B9D")]
		[Address(RVA = "0x7C34", Offset = "0x7C34", VA = "0x7C34")]
		public BackTimeView()
		{
		}

		// Token: 0x040017D8 RID: 6104
		[Token(Token = "0x40017D8")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private TextMeshProUGUI _title;

		// Token: 0x040017D9 RID: 6105
		[Token(Token = "0x40017D9")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private TextMeshProUGUI _timerNumbers;

		// Token: 0x040017DA RID: 6106
		[Token(Token = "0x40017DA")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private BacktimeViewUGUI _timer;

		// Token: 0x040017DB RID: 6107
		[Token(Token = "0x40017DB")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private Color32 _warnColor;

		// Token: 0x040017DC RID: 6108
		[Token(Token = "0x40017DC")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Color32 _color;

		// Token: 0x040017DD RID: 6109
		[Token(Token = "0x40017DD")]
		[FieldOffset(Offset = "0x24")]
		private TimerStrings _timerStrings;

		// Token: 0x040017DE RID: 6110
		[Token(Token = "0x40017DE")]
		[FieldOffset(Offset = "0x28")]
		private GdEventData _data;
	}
}
