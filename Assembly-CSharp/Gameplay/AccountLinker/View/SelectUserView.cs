using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Gameplay.AccountLinker.Model;
using Il2CppDummyDll;
using UnityEngine;

namespace Gameplay.AccountLinker.View
{
	// Token: 0x02000E03 RID: 3587
	[Token(Token = "0x2000E03")]
	public class SelectUserView : MonoBehaviour
	{
		// Token: 0x0600576A RID: 22378 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600576A")]
		[Address(RVA = "0xA4E5", Offset = "0xA4E5", VA = "0xA4E5")]
		private void OnDestroy()
		{
		}

		// Token: 0x170011D2 RID: 4562
		// (get) Token: 0x0600576B RID: 22379 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600576C RID: 22380 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170011D2")]
		public LinkerUser[] Users
		{
			[Token(Token = "0x600576B")]
			[Address(RVA = "0xA4E6", Offset = "0xA4E6", VA = "0xA4E6")]
			get
			{
				return null;
			}
			[Token(Token = "0x600576C")]
			[Address(RVA = "0xA4E7", Offset = "0xA4E7", VA = "0xA4E7")]
			set
			{
			}
		}

		// Token: 0x0600576D RID: 22381 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600576D")]
		[Address(RVA = "0xA4E8", Offset = "0xA4E8", VA = "0xA4E8")]
		private void HandleUsersChanged()
		{
		}

		// Token: 0x14000209 RID: 521
		// (add) Token: 0x0600576E RID: 22382 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600576F RID: 22383 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000209")]
		public event Action<LinkerUser> OnSelect
		{
			[Token(Token = "0x600576E")]
			[Address(RVA = "0xA4E9", Offset = "0xA4E9", VA = "0xA4E9")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600576F")]
			[Address(RVA = "0xA4EA", Offset = "0xA4EA", VA = "0xA4EA")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06005770 RID: 22384 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005770")]
		[Address(RVA = "0xA4EB", Offset = "0xA4EB", VA = "0xA4EB")]
		private void HandleOnSelectEvent(object sender, LinkerUser user)
		{
		}

		// Token: 0x06005771 RID: 22385 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005771")]
		[Address(RVA = "0xA4EC", Offset = "0xA4EC", VA = "0xA4EC")]
		public SelectUserView()
		{
		}

		// Token: 0x04002F5B RID: 12123
		[Token(Token = "0x4002F5B")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private AccountLinkerUserView _accountLinkerUserViewPrefab;

		// Token: 0x04002F5C RID: 12124
		[Token(Token = "0x4002F5C")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private Transform _owner;

		// Token: 0x04002F5D RID: 12125
		[Token(Token = "0x4002F5D")]
		[FieldOffset(Offset = "0x18")]
		private LinkerUser[] _users;

		// Token: 0x04002F5E RID: 12126
		[Token(Token = "0x4002F5E")]
		[FieldOffset(Offset = "0x1C")]
		private List<AccountLinkerUserView> _views;
	}
}
