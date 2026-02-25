using System;
using AssetContent;
using Gameplay.Portals.Model;
using Gameplay.Portals.View.TotalizatorTab;
using Il2CppDummyDll;
using TMPro;
using UI;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.Portals.View.MyBetsTab
{
	// Token: 0x020005C8 RID: 1480
	[Token(Token = "0x20005C8")]
	public class PortalsMyBetsView : MonoBehaviourWithStates<PortalsMyBetsView.State>
	{
		// Token: 0x1700069A RID: 1690
		// (get) Token: 0x0600237C RID: 9084 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700069A")]
		public PortalsTotalizatorOSAView UsersOSAView
		{
			[Token(Token = "0x600237C")]
			[Address(RVA = "0x74CE", Offset = "0x74CE", VA = "0x74CE")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700069B RID: 1691
		// (get) Token: 0x0600237D RID: 9085 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700069B")]
		public TextMeshProUGUI BetNumber
		{
			[Token(Token = "0x600237D")]
			[Address(RVA = "0x74CF", Offset = "0x74CF", VA = "0x74CF")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700069C RID: 1692
		// (get) Token: 0x0600237E RID: 9086 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700069C")]
		public Button AllBetsButton
		{
			[Token(Token = "0x600237E")]
			[Address(RVA = "0x74D0", Offset = "0x74D0", VA = "0x74D0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700069D RID: 1693
		// (get) Token: 0x0600237F RID: 9087 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700069D")]
		public Transform MyBetsContainer
		{
			[Token(Token = "0x600237F")]
			[Address(RVA = "0x74D1", Offset = "0x74D1", VA = "0x74D1")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700069E RID: 1694
		// (get) Token: 0x06002380 RID: 9088 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700069E")]
		public StageInPortalsMyBetsListElement MyBetsElementPrefab
		{
			[Token(Token = "0x6002380")]
			[Address(RVA = "0x74D2", Offset = "0x74D2", VA = "0x74D2")]
			get
			{
				return null;
			}
		}

		// Token: 0x06002381 RID: 9089 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002381")]
		[Address(RVA = "0x74D3", Offset = "0x74D3", VA = "0x74D3")]
		public void Init(PortalsModel model)
		{
		}

		// Token: 0x06002382 RID: 9090 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002382")]
		[Address(RVA = "0x74D4", Offset = "0x74D4", VA = "0x74D4")]
		public PortalsMyBetsView()
		{
		}

		// Token: 0x0400138C RID: 5004
		[Token(Token = "0x400138C")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private PortalsTotalizatorOSAView _usersOSAView;

		// Token: 0x0400138D RID: 5005
		[Token(Token = "0x400138D")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private TextMeshProUGUI _betNumber;

		// Token: 0x0400138E RID: 5006
		[Token(Token = "0x400138E")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private Button _allBetsButton;

		// Token: 0x0400138F RID: 5007
		[Token(Token = "0x400138F")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Transform _myBetsContainer;

		// Token: 0x04001390 RID: 5008
		[Token(Token = "0x4001390")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private StageInPortalsMyBetsListElement _myBetsElementPrefab;

		// Token: 0x04001391 RID: 5009
		[Token(Token = "0x4001391")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameRawImage _notAvailBanner;

		// Token: 0x020005C9 RID: 1481
		[Token(Token = "0x20005C9")]
		public enum State
		{
			// Token: 0x04001393 RID: 5011
			[Token(Token = "0x4001393")]
			UNKNOWN_STATE,
			// Token: 0x04001394 RID: 5012
			[Token(Token = "0x4001394")]
			HISTORY,
			// Token: 0x04001395 RID: 5013
			[Token(Token = "0x4001395")]
			BET_INFO,
			// Token: 0x04001396 RID: 5014
			[Token(Token = "0x4001396")]
			NOT_AVAIL
		}
	}
}
