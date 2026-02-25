using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using Utils;

namespace Gameplay.Inventory.View.Info.InfoBox
{
	// Token: 0x02000674 RID: 1652
	[Token(Token = "0x2000674")]
	public class BackTimeRowView : TitleRowView
	{
		// Token: 0x17000797 RID: 1943
		// (get) Token: 0x0600280F RID: 10255 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06002810 RID: 10256 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000797")]
		public BackTime Backtime
		{
			[Token(Token = "0x600280F")]
			[Address(RVA = "0x7934", Offset = "0x7934", VA = "0x7934")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002810")]
			[Address(RVA = "0x7935", Offset = "0x7935", VA = "0x7935")]
			set
			{
			}
		}

		// Token: 0x06002811 RID: 10257 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002811")]
		[Address(RVA = "0x7936", Offset = "0x7936", VA = "0x7936")]
		private void HandleBacktimeChanged()
		{
		}

		// Token: 0x06002812 RID: 10258 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002812")]
		[Address(RVA = "0x7937", Offset = "0x7937", VA = "0x7937")]
		private void DisplayTime()
		{
		}

		// Token: 0x06002813 RID: 10259 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002813")]
		[Address(RVA = "0x7938", Offset = "0x7938", VA = "0x7938", Slot = "5")]
		protected override void HandleDataChanged()
		{
		}

		// Token: 0x06002814 RID: 10260 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002814")]
		[Address(RVA = "0x7939", Offset = "0x7939", VA = "0x7939")]
		public BackTimeRowView()
		{
		}

		// Token: 0x0400160D RID: 5645
		[Token(Token = "0x400160D")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private TextMeshProUGUI _timeField;

		// Token: 0x0400160E RID: 5646
		[Token(Token = "0x400160E")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Color32 _warnTitleColor;

		// Token: 0x0400160F RID: 5647
		[Token(Token = "0x400160F")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private Color32 _idleTitleColor;

		// Token: 0x04001610 RID: 5648
		[Token(Token = "0x4001610")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Color32 _warnColor;

		// Token: 0x04001611 RID: 5649
		[Token(Token = "0x4001611")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private Color32 _idleColor;

		// Token: 0x04001612 RID: 5650
		[Token(Token = "0x4001612")]
		[FieldOffset(Offset = "0x38")]
		protected BackTime _backtime;
	}
}
