using System;
using AssetContent;
using Gameplay.Tutorial.Guide.Model;
using Gameplay.Tutorial.Guide.Model.Data.Config;
using Il2CppDummyDll;
using TMPro;
using UI;
using UnityEngine;

namespace Gameplay.Tutorial.Guide.View.Components
{
	// Token: 0x02000474 RID: 1140
	[Token(Token = "0x2000474")]
	public class Description : MonoBehaviourWithStates<AprLayout>
	{
		// Token: 0x06001AF9 RID: 6905 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001AF9")]
		[Address(RVA = "0x6C83", Offset = "0x6C83", VA = "0x6C83")]
		private void Start()
		{
		}

		// Token: 0x170004B3 RID: 1203
		// (get) Token: 0x06001AFA RID: 6906 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06001AFB RID: 6907 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170004B3")]
		public GuideConfig GuideConfig
		{
			[Token(Token = "0x6001AFA")]
			[Address(RVA = "0x6C84", Offset = "0x6C84", VA = "0x6C84")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001AFB")]
			[Address(RVA = "0x6C85", Offset = "0x6C85", VA = "0x6C85")]
			set
			{
			}
		}

		// Token: 0x06001AFC RID: 6908 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001AFC")]
		[Address(RVA = "0x6C86", Offset = "0x6C86", VA = "0x6C86")]
		private void HandleConfigChanged()
		{
		}

		// Token: 0x06001AFD RID: 6909 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001AFD")]
		[Address(RVA = "0x6C87", Offset = "0x6C87", VA = "0x6C87")]
		public void OnChanged()
		{
		}

		// Token: 0x06001AFE RID: 6910 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001AFE")]
		[Address(RVA = "0x6C88", Offset = "0x6C88", VA = "0x6C88")]
		public Description()
		{
		}

		// Token: 0x04000E89 RID: 3721
		[Token(Token = "0x4000E89")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private TextMeshProUGUI[] _descriptions;

		// Token: 0x04000E8A RID: 3722
		[Token(Token = "0x4000E8A")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameAssetViewRawImage[] _aprs;

		// Token: 0x04000E8B RID: 3723
		[Token(Token = "0x4000E8B")]
		[FieldOffset(Offset = "0x24")]
		private GuideConfig _guideConfig;
	}
}
