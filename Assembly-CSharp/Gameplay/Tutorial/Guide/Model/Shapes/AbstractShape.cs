using System;
using System.Runtime.CompilerServices;
using Gameplay.Tutorial.Guide.Model.Data.Config;
using Il2CppDummyDll;
using UnityEngine;

namespace Gameplay.Tutorial.Guide.Model.Shapes
{
	// Token: 0x02000480 RID: 1152
	[Token(Token = "0x2000480")]
	public abstract class AbstractShape : IDisposable
	{
		// Token: 0x170004C6 RID: 1222
		// (get) Token: 0x06001B4D RID: 6989 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06001B4E RID: 6990 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170004C6")]
		public StepLayoutConfig Config
		{
			[Token(Token = "0x6001B4D")]
			[Address(RVA = "0x6CD6", Offset = "0x6CD6", VA = "0x6CD6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001B4E")]
			[Address(RVA = "0x6CD7", Offset = "0x6CD7", VA = "0x6CD7")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170004C7 RID: 1223
		// (get) Token: 0x06001B4F RID: 6991 RVA: 0x00005CD0 File Offset: 0x00003ED0
		// (set) Token: 0x06001B50 RID: 6992 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170004C7")]
		public Rect Rect
		{
			[Token(Token = "0x6001B4F")]
			[Address(RVA = "0x6CD8", Offset = "0x6CD8", VA = "0x6CD8")]
			[CompilerGenerated]
			get
			{
				return default(Rect);
			}
			[Token(Token = "0x6001B50")]
			[Address(RVA = "0x6CD9", Offset = "0x6CD9", VA = "0x6CD9")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170004C8 RID: 1224
		// (get) Token: 0x06001B51 RID: 6993 RVA: 0x00005CE8 File Offset: 0x00003EE8
		// (set) Token: 0x06001B52 RID: 6994 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170004C8")]
		public float Gap
		{
			[Token(Token = "0x6001B51")]
			[Address(RVA = "0x6CDA", Offset = "0x6CDA", VA = "0x6CDA")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6001B52")]
			[Address(RVA = "0x6CDB", Offset = "0x6CDB", VA = "0x6CDB")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170004C9 RID: 1225
		// (get) Token: 0x06001B53 RID: 6995 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06001B54 RID: 6996 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170004C9")]
		public Transform Transform
		{
			[Token(Token = "0x6001B53")]
			[Address(RVA = "0x6CDC", Offset = "0x6CDC", VA = "0x6CDC")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001B54")]
			[Address(RVA = "0x6CDD", Offset = "0x6CDD", VA = "0x6CDD")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06001B55 RID: 6997
		[Token(Token = "0x6001B55")]
		public abstract float[] GetParams();

		// Token: 0x170004CA RID: 1226
		// (get) Token: 0x06001B56 RID: 6998
		[Token(Token = "0x170004CA")]
		public abstract Vector2 Size { [Token(Token = "0x6001B56")] get; }

		// Token: 0x06001B57 RID: 6999
		[Token(Token = "0x6001B57")]
		public abstract bool TryGetSprite(out Sprite sprite);

		// Token: 0x06001B58 RID: 7000 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B58")]
		[Address(RVA = "0x6CDE", Offset = "0x6CDE", VA = "0x6CDE", Slot = "4")]
		public void Dispose()
		{
		}

		// Token: 0x06001B59 RID: 7001 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B59")]
		[Address(RVA = "0x6CDF", Offset = "0x6CDF", VA = "0x6CDF")]
		protected AbstractShape()
		{
		}
	}
}
