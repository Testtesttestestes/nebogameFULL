using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.Medals.View
{
	// Token: 0x020005F9 RID: 1529
	[Token(Token = "0x20005F9")]
	public class MedalViewSelectable : MonoBehaviour
	{
		// Token: 0x1400014E RID: 334
		// (add) Token: 0x06002522 RID: 9506 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06002523 RID: 9507 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400014E")]
		public event Action<MedalViewSelectable> SelectEvent
		{
			[Token(Token = "0x6002522")]
			[Address(RVA = "0x766B", Offset = "0x766B", VA = "0x766B")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6002523")]
			[Address(RVA = "0x766C", Offset = "0x766C", VA = "0x766C")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06002524 RID: 9508 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002524")]
		[Address(RVA = "0x766D", Offset = "0x766D", VA = "0x766D")]
		private void Awake()
		{
		}

		// Token: 0x06002525 RID: 9509 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002525")]
		[Address(RVA = "0x766E", Offset = "0x766E", VA = "0x766E")]
		private void OnDestroy()
		{
		}

		// Token: 0x170006F6 RID: 1782
		// (get) Token: 0x06002526 RID: 9510 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170006F6")]
		public MedalView MedalView
		{
			[Token(Token = "0x6002526")]
			[Address(RVA = "0x766F", Offset = "0x766F", VA = "0x766F")]
			get
			{
				return null;
			}
		}

		// Token: 0x06002527 RID: 9511 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002527")]
		[Address(RVA = "0x7670", Offset = "0x7670", VA = "0x7670")]
		private void MedalViewOnClickEvent(MedalView obj)
		{
		}

		// Token: 0x170006F7 RID: 1783
		// (get) Token: 0x06002528 RID: 9512 RVA: 0x00007110 File Offset: 0x00005310
		// (set) Token: 0x06002529 RID: 9513 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170006F7")]
		public bool IsSelected
		{
			[Token(Token = "0x6002528")]
			[Address(RVA = "0x7671", Offset = "0x7671", VA = "0x7671")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002529")]
			[Address(RVA = "0x7672", Offset = "0x7672", VA = "0x7672")]
			set
			{
			}
		}

		// Token: 0x0600252A RID: 9514 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600252A")]
		[Address(RVA = "0x7673", Offset = "0x7673", VA = "0x7673")]
		public MedalViewSelectable()
		{
		}

		// Token: 0x0400144F RID: 5199
		[Token(Token = "0x400144F")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private MedalView _medalView;

		// Token: 0x04001450 RID: 5200
		[Token(Token = "0x4001450")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private Image _selectorView;

		// Token: 0x04001451 RID: 5201
		[Token(Token = "0x4001451")]
		[FieldOffset(Offset = "0x18")]
		private bool _isSelected;
	}
}
