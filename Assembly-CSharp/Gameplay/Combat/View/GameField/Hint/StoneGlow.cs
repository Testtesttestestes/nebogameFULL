using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Protocol.Combat;
using UnityEngine;
using Utils.Cache;

namespace Gameplay.Combat.View.GameField.Hint
{
	// Token: 0x02000978 RID: 2424
	[Token(Token = "0x2000978")]
	public class StoneGlow : MonoBehaviour, IPoolElement<StoneGlow>
	{
		// Token: 0x060039BD RID: 14781 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60039BD")]
		[Address(RVA = "0x894D", Offset = "0x894D", VA = "0x894D")]
		private void Start()
		{
		}

		// Token: 0x060039BE RID: 14782 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60039BE")]
		[Address(RVA = "0x19E0", Offset = "0x19E0", VA = "0x19E0")]
		public void StopGlow()
		{
		}

		// Token: 0x060039BF RID: 14783 RVA: 0x0000B868 File Offset: 0x00009A68
		[Token(Token = "0x60039BF")]
		[Address(RVA = "0x894E", Offset = "0x894E", VA = "0x894E")]
		public float Glow(StonesTypes stoneType, uint setID)
		{
			return 0f;
		}

		// Token: 0x17000B53 RID: 2899
		// (get) Token: 0x060039C0 RID: 14784 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060039C1 RID: 14785 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B53")]
		public ObjectPool<StoneGlow> Pool
		{
			[Token(Token = "0x60039C0")]
			[Address(RVA = "0x894F", Offset = "0x894F", VA = "0x894F", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60039C1")]
			[Address(RVA = "0x8950", Offset = "0x8950", VA = "0x8950", Slot = "5")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060039C2 RID: 14786 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60039C2")]
		[Address(RVA = "0x19E1", Offset = "0x19E1", VA = "0x19E1", Slot = "6")]
		public void Release()
		{
		}

		// Token: 0x060039C3 RID: 14787 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60039C3")]
		[Address(RVA = "0x8951", Offset = "0x8951", VA = "0x8951")]
		public StoneGlow()
		{
		}

		// Token: 0x04001FF3 RID: 8179
		[Token(Token = "0x4001FF3")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private float _defaultDuration;

		// Token: 0x04001FF4 RID: 8180
		[Token(Token = "0x4001FF4")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private List<StoneGlowElement> _glowElements;
	}
}
