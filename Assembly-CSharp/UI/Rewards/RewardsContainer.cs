using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace UI.Rewards
{
	// Token: 0x02000196 RID: 406
	[Token(Token = "0x2000196")]
	public class RewardsContainer : MonoBehaviour
	{
		// Token: 0x140000E1 RID: 225
		// (add) Token: 0x06000B4E RID: 2894 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000B4F RID: 2895 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140000E1")]
		public event Action OnDestroyEvent
		{
			[Token(Token = "0x6000B4E")]
			[Address(RVA = "0x5E6D", Offset = "0x5E6D", VA = "0x5E6D")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000B4F")]
			[Address(RVA = "0x5E6E", Offset = "0x5E6E", VA = "0x5E6E")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06000B50 RID: 2896 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000B50")]
		public virtual T Add<T>(T prefab) where T : AbstractRewardRender
		{
			return null;
		}

		// Token: 0x06000B51 RID: 2897 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B51")]
		[Address(RVA = "0x5E6F", Offset = "0x5E6F", VA = "0x5E6F")]
		public void Dispose()
		{
		}

		// Token: 0x06000B52 RID: 2898 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B52")]
		[Address(RVA = "0x5E70", Offset = "0x5E70", VA = "0x5E70")]
		private void OnDestroy()
		{
		}

		// Token: 0x06000B53 RID: 2899 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B53")]
		[Address(RVA = "0x5E71", Offset = "0x5E71", VA = "0x5E71")]
		public RewardsContainer()
		{
		}

		// Token: 0x04000520 RID: 1312
		[Token(Token = "0x4000520")]
		[FieldOffset(Offset = "0x14")]
		public Color32 LabelColor;

		// Token: 0x04000521 RID: 1313
		[Token(Token = "0x4000521")]
		[FieldOffset(Offset = "0x18")]
		public Color32 ValueColor;

		// Token: 0x04000522 RID: 1314
		[Token(Token = "0x4000522")]
		[FieldOffset(Offset = "0x1C")]
		public readonly List<AbstractRewardRender> Renderers;
	}
}
