using System;
using AssetContent.Loaders;
using Il2CppDummyDll;
using Protocol.Dic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Gameplay.UserInterface.Menu.ExternalLinks.View
{
	// Token: 0x020003E2 RID: 994
	[Token(Token = "0x20003E2")]
	[DisallowMultipleComponent]
	[RequireComponent(typeof(Button))]
	public class ExternalLinkButtonView : MonoBehaviour
	{
		// Token: 0x17000408 RID: 1032
		// (get) Token: 0x06001743 RID: 5955 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06001744 RID: 5956 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000408")]
		public OptionsMenuButton Data
		{
			[Token(Token = "0x6001743")]
			[Address(RVA = "0x6902", Offset = "0x6902", VA = "0x6902")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001744")]
			[Address(RVA = "0x1F22", Offset = "0x1F22", VA = "0x1F22")]
			set
			{
			}
		}

		// Token: 0x06001745 RID: 5957 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001745")]
		[Address(RVA = "0x6903", Offset = "0x6903", VA = "0x6903")]
		private void Start()
		{
		}

		// Token: 0x06001746 RID: 5958 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001746")]
		[Address(RVA = "0x6904", Offset = "0x6904", VA = "0x6904")]
		private void OnDestroy()
		{
		}

		// Token: 0x06001747 RID: 5959 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001747")]
		[Address(RVA = "0x6905", Offset = "0x6905", VA = "0x6905")]
		private void OnClick()
		{
		}

		// Token: 0x06001748 RID: 5960 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001748")]
		[Address(RVA = "0x6906", Offset = "0x6906", VA = "0x6906")]
		public ExternalLinkButtonView()
		{
		}

		// Token: 0x04000C5B RID: 3163
		[Token(Token = "0x4000C5B")]
		[FieldOffset(Offset = "0x10")]
		private OptionsMenuButton _data;

		// Token: 0x04000C5C RID: 3164
		[Token(Token = "0x4000C5C")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private GameImageLoader _gameImageLoader;

		// Token: 0x04000C5D RID: 3165
		[Token(Token = "0x4000C5D")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private TextMeshProUGUI _title;

		// Token: 0x04000C5E RID: 3166
		[Token(Token = "0x4000C5E")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private TextMeshProUGUI _description;

		// Token: 0x04000C5F RID: 3167
		[Token(Token = "0x4000C5F")]
		[FieldOffset(Offset = "0x20")]
		[Space(10f)]
		public UnityEvent<OptionsMenuButton> onClick;
	}
}
