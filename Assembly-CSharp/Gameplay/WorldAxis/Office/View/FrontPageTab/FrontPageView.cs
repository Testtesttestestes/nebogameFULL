using System;
using Il2CppDummyDll;
using TMPro;
using UI;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.WorldAxis.Office.View.FrontPageTab
{
	// Token: 0x0200031A RID: 794
	[Token(Token = "0x200031A")]
	public class FrontPageView : MonoBehaviour
	{
		// Token: 0x170002C6 RID: 710
		// (get) Token: 0x06001255 RID: 4693 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170002C6")]
		public BacktimeViewUGUI SeasonBacktime
		{
			[Token(Token = "0x6001255")]
			[Address(RVA = "0x644F", Offset = "0x644F", VA = "0x644F")]
			get
			{
				return null;
			}
		}

		// Token: 0x170002C7 RID: 711
		// (get) Token: 0x06001256 RID: 4694 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170002C7")]
		public TextMeshProUGUI SeasonStatusText
		{
			[Token(Token = "0x6001256")]
			[Address(RVA = "0x6450", Offset = "0x6450", VA = "0x6450")]
			get
			{
				return null;
			}
		}

		// Token: 0x170002C8 RID: 712
		// (get) Token: 0x06001257 RID: 4695 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170002C8")]
		public Button CreateClanButton
		{
			[Token(Token = "0x6001257")]
			[Address(RVA = "0x6451", Offset = "0x6451", VA = "0x6451")]
			get
			{
				return null;
			}
		}

		// Token: 0x170002C9 RID: 713
		// (get) Token: 0x06001258 RID: 4696 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170002C9")]
		public Button ToWorldAxisButton
		{
			[Token(Token = "0x6001258")]
			[Address(RVA = "0x6452", Offset = "0x6452", VA = "0x6452")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001259 RID: 4697 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001259")]
		[Address(RVA = "0x6453", Offset = "0x6453", VA = "0x6453")]
		public FrontPageView()
		{
		}

		// Token: 0x040009C8 RID: 2504
		[Token(Token = "0x40009C8")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private BacktimeViewUGUI _seasonBacktime;

		// Token: 0x040009C9 RID: 2505
		[Token(Token = "0x40009C9")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private TextMeshProUGUI _seasonStatusText;

		// Token: 0x040009CA RID: 2506
		[Token(Token = "0x40009CA")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Button _createClanButton;

		// Token: 0x040009CB RID: 2507
		[Token(Token = "0x40009CB")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private Button _toWorldAxisButton;
	}
}
