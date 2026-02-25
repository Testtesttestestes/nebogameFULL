using System;
using System.Collections;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using Utils;

namespace Gameplay.Inventory.View.Info.InfoBox
{
	// Token: 0x02000675 RID: 1653
	[Token(Token = "0x2000675")]
	public class BacktimeRowViewDynamic : TitleRowView
	{
		// Token: 0x17000798 RID: 1944
		// (get) Token: 0x06002815 RID: 10261 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06002816 RID: 10262 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000798")]
		public BackTime Backtime
		{
			[Token(Token = "0x6002815")]
			[Address(RVA = "0x793A", Offset = "0x793A", VA = "0x793A")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002816")]
			[Address(RVA = "0x793B", Offset = "0x793B", VA = "0x793B")]
			set
			{
			}
		}

		// Token: 0x06002817 RID: 10263 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002817")]
		[Address(RVA = "0x793C", Offset = "0x793C", VA = "0x793C")]
		private void OnDestroy()
		{
		}

		// Token: 0x06002818 RID: 10264 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002818")]
		[Address(RVA = "0x793D", Offset = "0x793D", VA = "0x793D")]
		private void HandleBacktimeChanged()
		{
		}

		// Token: 0x06002819 RID: 10265 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6002819")]
		[Address(RVA = "0x793E", Offset = "0x793E", VA = "0x793E")]
		private IEnumerator DisplayBacktimeCoroutine()
		{
			return null;
		}

		// Token: 0x0600281A RID: 10266 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600281A")]
		[Address(RVA = "0x793F", Offset = "0x793F", VA = "0x793F")]
		private void DisplayTime()
		{
		}

		// Token: 0x0600281B RID: 10267 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600281B")]
		[Address(RVA = "0x7940", Offset = "0x7940", VA = "0x7940", Slot = "5")]
		protected override void HandleDataChanged()
		{
		}

		// Token: 0x0600281C RID: 10268 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600281C")]
		[Address(RVA = "0x7941", Offset = "0x7941", VA = "0x7941")]
		public BacktimeRowViewDynamic()
		{
		}

		// Token: 0x04001613 RID: 5651
		[Token(Token = "0x4001613")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private TextMeshProUGUI _timeField;

		// Token: 0x04001614 RID: 5652
		[Token(Token = "0x4001614")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Color32 _warnTitleColor;

		// Token: 0x04001615 RID: 5653
		[Token(Token = "0x4001615")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private Color32 _idleTitleColor;

		// Token: 0x04001616 RID: 5654
		[Token(Token = "0x4001616")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Color32 _warnColor;

		// Token: 0x04001617 RID: 5655
		[Token(Token = "0x4001617")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private Color32 _idleColor;

		// Token: 0x04001618 RID: 5656
		[Token(Token = "0x4001618")]
		[FieldOffset(Offset = "0x38")]
		protected BackTime _backtime;

		// Token: 0x04001619 RID: 5657
		[Token(Token = "0x4001619")]
		[FieldOffset(Offset = "0x3C")]
		private Coroutine _routine;
	}
}
