using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Animations;
using Core.Data;
using Core.Dict;
using Il2CppDummyDll;
using MVC;
using Protocol.Main;

namespace Gameplay.ArtifactDrop.Model
{
	// Token: 0x02000CC8 RID: 3272
	[Token(Token = "0x2000CC8")]
	public class ArtifactDropModel : AbstractModel
	{
		// Token: 0x17001026 RID: 4134
		// (get) Token: 0x06004FA3 RID: 20387 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001026")]
		public IAnimationProvider AnimationProvider
		{
			[Token(Token = "0x6004FA3")]
			[Address(RVA = "0x9DBC", Offset = "0x9DBC", VA = "0x9DBC")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001027 RID: 4135
		// (get) Token: 0x06004FA4 RID: 20388 RVA: 0x0000EA60 File Offset: 0x0000CC60
		// (set) Token: 0x06004FA5 RID: 20389 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001027")]
		public bool UseAnimation
		{
			[Token(Token = "0x6004FA4")]
			[Address(RVA = "0x9DBD", Offset = "0x9DBD", VA = "0x9DBD")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6004FA5")]
			[Address(RVA = "0x9DBE", Offset = "0x9DBE", VA = "0x9DBE")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17001028 RID: 4136
		// (get) Token: 0x06004FA6 RID: 20390 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001028")]
		public Dictionary<DropTypes, ArtifactDropModel.ArtifactDrop> DropCache
		{
			[Token(Token = "0x6004FA6")]
			[Address(RVA = "0x9DBF", Offset = "0x9DBF", VA = "0x9DBF")]
			get
			{
				return null;
			}
		}

		// Token: 0x06004FA7 RID: 20391 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004FA7")]
		[Address(RVA = "0x9DC0", Offset = "0x9DC0", VA = "0x9DC0", Slot = "5")]
		public override void Dispose()
		{
		}

		// Token: 0x06004FA8 RID: 20392 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004FA8")]
		[Address(RVA = "0x9DC1", Offset = "0x9DC1", VA = "0x9DC1")]
		public ArtifactDropModel(UserData user, IDictProvider dictProvider, IAnimationProvider animationProvider)
		{
		}

		// Token: 0x06004FA9 RID: 20393 RVA: 0x0000EA78 File Offset: 0x0000CC78
		[Token(Token = "0x6004FA9")]
		[Address(RVA = "0x9DC2", Offset = "0x9DC2", VA = "0x9DC2")]
		public bool TryGetDrop(DropTypes dropType, out ArtifactDropModel.ArtifactDrop drop)
		{
			return default(bool);
		}

		// Token: 0x06004FAA RID: 20394 RVA: 0x0000EA90 File Offset: 0x0000CC90
		[Token(Token = "0x6004FAA")]
		[Address(RVA = "0x9DC3", Offset = "0x9DC3", VA = "0x9DC3")]
		public bool TryGetDrop(ArtifactData artifactData, out ArtifactDropModel.ArtifactDrop drop)
		{
			return default(bool);
		}

		// Token: 0x06004FAB RID: 20395 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004FAB")]
		[Address(RVA = "0x9DC4", Offset = "0x9DC4", VA = "0x9DC4")]
		public void SetDrop(ArtifactDropModel.ArtifactDrop drop)
		{
		}

		// Token: 0x06004FAC RID: 20396 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004FAC")]
		[Address(RVA = "0x9DC5", Offset = "0x9DC5", VA = "0x9DC5")]
		public void Remove(DropTypes dropType)
		{
		}

		// Token: 0x06004FAD RID: 20397 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004FAD")]
		[Address(RVA = "0x9DC6", Offset = "0x9DC6", VA = "0x9DC6")]
		public void RemoveAll()
		{
		}

		// Token: 0x04002B63 RID: 11107
		[Token(Token = "0x4002B63")]
		[FieldOffset(Offset = "0xC")]
		private readonly IAnimationProvider _emptyAnimationProvider;

		// Token: 0x04002B64 RID: 11108
		[Token(Token = "0x4002B64")]
		[FieldOffset(Offset = "0x10")]
		private readonly IAnimationProvider _animationProvider;

		// Token: 0x04002B65 RID: 11109
		[Token(Token = "0x4002B65")]
		[FieldOffset(Offset = "0x14")]
		private readonly Dictionary<DropTypes, ArtifactDropModel.ArtifactDrop> _cache;

		// Token: 0x04002B67 RID: 11111
		[Token(Token = "0x4002B67")]
		[FieldOffset(Offset = "0x1C")]
		public readonly IDictProvider DictProvider;

		// Token: 0x02000CC9 RID: 3273
		[Token(Token = "0x2000CC9")]
		public class ArtifactDrop
		{
			// Token: 0x06004FAE RID: 20398 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6004FAE")]
			[Address(RVA = "0x9DC7", Offset = "0x9DC7", VA = "0x9DC7")]
			public ArtifactDrop(DropTypes dropType, bool limitExceeded)
			{
			}

			// Token: 0x04002B68 RID: 11112
			[Token(Token = "0x4002B68")]
			[FieldOffset(Offset = "0x8")]
			public readonly DropTypes DropType;

			// Token: 0x04002B69 RID: 11113
			[Token(Token = "0x4002B69")]
			[FieldOffset(Offset = "0xC")]
			public readonly List<ArtifactData> Artifacts;

			// Token: 0x04002B6A RID: 11114
			[Token(Token = "0x4002B6A")]
			[FieldOffset(Offset = "0x10")]
			public readonly bool LimitExceeded;
		}
	}
}
