using System;
using System.Collections.Generic;
using Core.Animations;
using Il2CppDummyDll;
using Protocol.Combat;
using UnityEngine;

namespace Gameplay.Combat.View.GameField.Hint
{
	// Token: 0x0200097A RID: 2426
	[Token(Token = "0x200097A")]
	[Serializable]
	public class StoneGlowElement
	{
		// Token: 0x17000B54 RID: 2900
		// (get) Token: 0x060039C6 RID: 14790 RVA: 0x0000B898 File Offset: 0x00009A98
		[Token(Token = "0x17000B54")]
		public StonesTypes Type
		{
			[Token(Token = "0x60039C6")]
			[Address(RVA = "0x8954", Offset = "0x8954", VA = "0x8954")]
			get
			{
				return StonesTypes.Empty;
			}
		}

		// Token: 0x17000B55 RID: 2901
		// (get) Token: 0x060039C7 RID: 14791 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000B55")]
		public List<uint> SetID
		{
			[Token(Token = "0x60039C7")]
			[Address(RVA = "0x8955", Offset = "0x8955", VA = "0x8955")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000B56 RID: 2902
		// (get) Token: 0x060039C8 RID: 14792 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000B56")]
		public GameSpineAnimation Animation
		{
			[Token(Token = "0x60039C8")]
			[Address(RVA = "0x8956", Offset = "0x8956", VA = "0x8956")]
			get
			{
				return null;
			}
		}

		// Token: 0x060039C9 RID: 14793 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60039C9")]
		[Address(RVA = "0x8957", Offset = "0x8957", VA = "0x8957")]
		public StoneGlowElement()
		{
		}

		// Token: 0x04001FF8 RID: 8184
		[Token(Token = "0x4001FF8")]
		[FieldOffset(Offset = "0x8")]
		[SerializeField]
		private StonesTypes _type;

		// Token: 0x04001FF9 RID: 8185
		[Token(Token = "0x4001FF9")]
		[FieldOffset(Offset = "0xC")]
		[SerializeField]
		private List<uint> _setID;

		// Token: 0x04001FFA RID: 8186
		[Token(Token = "0x4001FFA")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private GameSpineAnimation _animation;
	}
}
