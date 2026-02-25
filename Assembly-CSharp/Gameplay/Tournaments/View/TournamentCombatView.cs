using System;
using Gameplay.Combat.View;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.Tournaments.View
{
	// Token: 0x020004A6 RID: 1190
	[Token(Token = "0x20004A6")]
	public class TournamentCombatView : OneOnOneCombatView
	{
		// Token: 0x170004F1 RID: 1265
		// (get) Token: 0x06001C21 RID: 7201 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170004F1")]
		public Button CloseButton
		{
			[Token(Token = "0x6001C21")]
			[Address(RVA = "0x6DA0", Offset = "0x6DA0", VA = "0x6DA0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170004F2 RID: 1266
		// (get) Token: 0x06001C22 RID: 7202 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170004F2")]
		public GameObject Blocker
		{
			[Token(Token = "0x6001C22")]
			[Address(RVA = "0x6DA1", Offset = "0x6DA1", VA = "0x6DA1")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001C23 RID: 7203 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C23")]
		[Address(RVA = "0x6DA2", Offset = "0x6DA2", VA = "0x6DA2", Slot = "6")]
		protected override void Start()
		{
		}

		// Token: 0x06001C24 RID: 7204 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C24")]
		[Address(RVA = "0x6DA3", Offset = "0x6DA3", VA = "0x6DA3")]
		public TournamentCombatView()
		{
		}

		// Token: 0x04000F31 RID: 3889
		[Token(Token = "0x4000F31")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private GameObject _blocker;

		// Token: 0x04000F32 RID: 3890
		[Token(Token = "0x4000F32")]
		[FieldOffset(Offset = "0x74")]
		[SerializeField]
		private Button _closeButton;
	}
}
