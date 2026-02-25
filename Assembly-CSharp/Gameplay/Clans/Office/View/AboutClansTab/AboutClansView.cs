using System;
using Il2CppDummyDll;
using UI.Tabs;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.Clans.Office.View.AboutClansTab
{
	// Token: 0x02000A41 RID: 2625
	[Token(Token = "0x2000A41")]
	public class AboutClansView : MonoBehaviour
	{
		// Token: 0x17000C71 RID: 3185
		// (get) Token: 0x06003E1E RID: 15902 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000C71")]
		public Button CreateClanButton
		{
			[Token(Token = "0x6003E1E")]
			[Address(RVA = "0x8CDD", Offset = "0x8CDD", VA = "0x8CDD")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000C72 RID: 3186
		// (get) Token: 0x06003E1F RID: 15903 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000C72")]
		public Button FindClanButton
		{
			[Token(Token = "0x6003E1F")]
			[Address(RVA = "0x8CDE", Offset = "0x8CDE", VA = "0x8CDE")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000C73 RID: 3187
		// (get) Token: 0x06003E20 RID: 15904 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000C73")]
		public TabBar TabBar
		{
			[Token(Token = "0x6003E20")]
			[Address(RVA = "0x8CDF", Offset = "0x8CDF", VA = "0x8CDF")]
			get
			{
				return null;
			}
		}

		// Token: 0x06003E21 RID: 15905 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003E21")]
		[Address(RVA = "0x8CE0", Offset = "0x8CE0", VA = "0x8CE0")]
		public AboutClansView()
		{
		}

		// Token: 0x040022E3 RID: 8931
		[Token(Token = "0x40022E3")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private TabBar _tabBar;

		// Token: 0x040022E4 RID: 8932
		[Token(Token = "0x40022E4")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private Button _createClanButton;

		// Token: 0x040022E5 RID: 8933
		[Token(Token = "0x40022E5")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Button _findClanButton;
	}
}
