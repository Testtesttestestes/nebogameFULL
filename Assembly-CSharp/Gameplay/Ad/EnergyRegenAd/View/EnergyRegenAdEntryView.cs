using System;
using System.Collections;
using Core.Gameplay.Managers.Ad.Placements.EnergyRegen;
using Il2CppDummyDll;
using Protocol.Consts;
using UnityEngine;

namespace Gameplay.Ad.EnergyRegenAd.View
{
	// Token: 0x02000DA9 RID: 3497
	[Token(Token = "0x2000DA9")]
	public class EnergyRegenAdEntryView : MonoBehaviour
	{
		// Token: 0x0600557D RID: 21885 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600557D")]
		[Address(RVA = "0xA31D", Offset = "0xA31D", VA = "0xA31D")]
		public void Init(Protocol.Consts.Resources resourceId)
		{
		}

		// Token: 0x0600557E RID: 21886 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600557E")]
		[Address(RVA = "0xA31E", Offset = "0xA31E", VA = "0xA31E")]
		private IEnumerator HandleAdAvailability(Protocol.Consts.Resources resourceId, EnergyRegenAdPlacementManager energyRegenAdManager)
		{
			return null;
		}

		// Token: 0x0600557F RID: 21887 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600557F")]
		[Address(RVA = "0xA31F", Offset = "0xA31F", VA = "0xA31F")]
		public EnergyRegenAdEntryView()
		{
		}

		// Token: 0x04002E42 RID: 11842
		[Token(Token = "0x4002E42")]
		public const string PREFAB_PATH = "Prefabs/UI/Ad/EnergyRegenAdView";

		// Token: 0x04002E43 RID: 11843
		[Token(Token = "0x4002E43")]
		[FieldOffset(Offset = "0x10")]
		private bool _adAvailable;
	}
}
