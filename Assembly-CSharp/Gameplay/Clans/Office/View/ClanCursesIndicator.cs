using System;
using Gameplay.World.Model;
using Il2CppDummyDll;
using UI.Elements.Counters;
using UnityEngine;
using UnityEngine.UI;
using Utils.Timers;

namespace Gameplay.Clans.Office.View
{
	// Token: 0x020009EF RID: 2543
	[Token(Token = "0x20009EF")]
	public class ClanCursesIndicator : MonoBehaviour
	{
		// Token: 0x17000BF4 RID: 3060
		// (get) Token: 0x06003CB6 RID: 15542 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000BF4")]
		private DelayedCall Timer
		{
			[Token(Token = "0x6003CB6")]
			[Address(RVA = "0x8B79", Offset = "0x8B79", VA = "0x8B79")]
			get
			{
				return null;
			}
		}

		// Token: 0x06003CB7 RID: 15543 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003CB7")]
		[Address(RVA = "0x8B7A", Offset = "0x8B7A", VA = "0x8B7A")]
		private void Awake()
		{
		}

		// Token: 0x06003CB8 RID: 15544 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003CB8")]
		[Address(RVA = "0x8B7B", Offset = "0x8B7B", VA = "0x8B7B")]
		private void OnDestroy()
		{
		}

		// Token: 0x06003CB9 RID: 15545 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003CB9")]
		[Address(RVA = "0x8B7C", Offset = "0x8B7C", VA = "0x8B7C")]
		public void SetClanData(ClanData data)
		{
		}

		// Token: 0x06003CBA RID: 15546 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003CBA")]
		[Address(RVA = "0x8B7D", Offset = "0x8B7D", VA = "0x8B7D")]
		private void UpdateData()
		{
		}

		// Token: 0x06003CBB RID: 15547 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003CBB")]
		[Address(RVA = "0x8B7E", Offset = "0x8B7E", VA = "0x8B7E")]
		private void ButtonClickedEventHandler()
		{
		}

		// Token: 0x06003CBC RID: 15548 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003CBC")]
		[Address(RVA = "0x8B7F", Offset = "0x8B7F", VA = "0x8B7F")]
		public ClanCursesIndicator()
		{
		}

		// Token: 0x04002189 RID: 8585
		[Token(Token = "0x4002189")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private CounterAutoHide _counter;

		// Token: 0x0400218A RID: 8586
		[Token(Token = "0x400218A")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private Button _button;

		// Token: 0x0400218B RID: 8587
		[Token(Token = "0x400218B")]
		[FieldOffset(Offset = "0x18")]
		private ClanData _clanData;

		// Token: 0x0400218C RID: 8588
		[Token(Token = "0x400218C")]
		[FieldOffset(Offset = "0x1C")]
		private DelayedCall _timer;
	}
}
