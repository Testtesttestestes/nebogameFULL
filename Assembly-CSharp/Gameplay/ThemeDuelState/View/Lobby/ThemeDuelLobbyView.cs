using System;
using AssetContent;
using Gameplay.ThemeDuelState.Control;
using Gameplay.ThemeDuelState.Model;
using Il2CppDummyDll;
using TMPro;
using UI;
using UnityEngine;

namespace Gameplay.ThemeDuelState.View.Lobby
{
	// Token: 0x020004CE RID: 1230
	[Token(Token = "0x20004CE")]
	public class ThemeDuelLobbyView : MonoBehaviour
	{
		// Token: 0x17000539 RID: 1337
		// (get) Token: 0x06001D3A RID: 7482 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000539")]
		public IndexButtonBasic ThemeDuelButton
		{
			[Token(Token = "0x6001D3A")]
			[Address(RVA = "0x6EB9", Offset = "0x6EB9", VA = "0x6EB9")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700053A RID: 1338
		// (get) Token: 0x06001D3B RID: 7483 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700053A")]
		public TextMeshProUGUI ThemeDuelScore
		{
			[Token(Token = "0x6001D3B")]
			[Address(RVA = "0x6EBA", Offset = "0x6EBA", VA = "0x6EBA")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001D3C RID: 7484 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D3C")]
		[Address(RVA = "0x6EBB", Offset = "0x6EBB", VA = "0x6EBB")]
		private void Awake()
		{
		}

		// Token: 0x06001D3D RID: 7485 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D3D")]
		[Address(RVA = "0x6EBC", Offset = "0x6EBC", VA = "0x6EBC")]
		private void OnDestroy()
		{
		}

		// Token: 0x06001D3E RID: 7486 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D3E")]
		[Address(RVA = "0x6EBD", Offset = "0x6EBD", VA = "0x6EBD")]
		public void UpdateView(string iconAssetId)
		{
		}

		// Token: 0x06001D3F RID: 7487 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D3F")]
		[Address(RVA = "0x6EBE", Offset = "0x6EBE", VA = "0x6EBE")]
		private void SetupMVC()
		{
		}

		// Token: 0x06001D40 RID: 7488 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D40")]
		[Address(RVA = "0x6EBF", Offset = "0x6EBF", VA = "0x6EBF")]
		private void DestroyMVC()
		{
		}

		// Token: 0x06001D41 RID: 7489 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D41")]
		[Address(RVA = "0x6EC0", Offset = "0x6EC0", VA = "0x6EC0")]
		public ThemeDuelLobbyView()
		{
		}

		// Token: 0x04000FE6 RID: 4070
		[Token(Token = "0x4000FE6")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private IndexButtonBasic _themeDuelButton;

		// Token: 0x04000FE7 RID: 4071
		[Token(Token = "0x4000FE7")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private TextMeshProUGUI _themeDuelScore;

		// Token: 0x04000FE8 RID: 4072
		[Token(Token = "0x4000FE8")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameRawImage _icon;

		// Token: 0x04000FE9 RID: 4073
		[Token(Token = "0x4000FE9")]
		[FieldOffset(Offset = "0x1C")]
		private ThemeDuelLobbyMediator _mediator;

		// Token: 0x04000FEA RID: 4074
		[Token(Token = "0x4000FEA")]
		[FieldOffset(Offset = "0x20")]
		private ThemeDuelStateEvents _events;

		// Token: 0x04000FEB RID: 4075
		[Token(Token = "0x4000FEB")]
		[FieldOffset(Offset = "0x24")]
		private ThemeDuelStateModel _model;

		// Token: 0x04000FEC RID: 4076
		[Token(Token = "0x4000FEC")]
		[FieldOffset(Offset = "0x28")]
		private ThemeDuelStateController _controller;
	}
}
