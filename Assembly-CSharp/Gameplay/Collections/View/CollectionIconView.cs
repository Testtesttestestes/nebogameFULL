using System;
using System.Runtime.CompilerServices;
using AssetContent;
using Core.Data;
using Core.Dict;
using Il2CppDummyDll;
using JetBrains.Annotations;
using UnityEngine;

namespace Gameplay.Collections.View
{
	// Token: 0x020009BF RID: 2495
	[Token(Token = "0x20009BF")]
	public class CollectionIconView : MonoBehaviour
	{
		// Token: 0x06003BBF RID: 15295 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003BBF")]
		[Address(RVA = "0x8A95", Offset = "0x8A95", VA = "0x8A95")]
		private void OnDestroy()
		{
		}

		// Token: 0x06003BC0 RID: 15296 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003BC0")]
		[Address(RVA = "0x1AA4", Offset = "0x1AA4", VA = "0x1AA4")]
		public void Init(IDictProvider dictProvider, UserData user)
		{
		}

		// Token: 0x17000BC9 RID: 3017
		// (get) Token: 0x06003BC1 RID: 15297 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06003BC2 RID: 15298 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000BC9")]
		public CollectionData Data
		{
			[Token(Token = "0x6003BC1")]
			[Address(RVA = "0x8A96", Offset = "0x8A96", VA = "0x8A96")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003BC2")]
			[Address(RVA = "0x8A97", Offset = "0x8A97", VA = "0x8A97")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000BCA RID: 3018
		// (get) Token: 0x06003BC3 RID: 15299 RVA: 0x0000C060 File Offset: 0x0000A260
		// (set) Token: 0x06003BC4 RID: 15300 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000BCA")]
		public uint Rank
		{
			[Token(Token = "0x6003BC3")]
			[Address(RVA = "0x8A98", Offset = "0x8A98", VA = "0x8A98")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x6003BC4")]
			[Address(RVA = "0x1AA6", Offset = "0x1AA6", VA = "0x1AA6")]
			set
			{
			}
		}

		// Token: 0x06003BC5 RID: 15301 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003BC5")]
		[Address(RVA = "0x8A99", Offset = "0x8A99", VA = "0x8A99")]
		private void HandleRankChanged()
		{
		}

		// Token: 0x06003BC6 RID: 15302 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003BC6")]
		[Address(RVA = "0x8A9A", Offset = "0x8A9A", VA = "0x8A9A")]
		private void Draw([NotNull] string iconAssetId, [NotNull] string rankFrameAssetId, Vector3 scale, [CanBeNull] string ribbonAssetId, [CanBeNull] string rankBackgroundAssetId)
		{
		}

		// Token: 0x17000BCB RID: 3019
		// (get) Token: 0x06003BC7 RID: 15303 RVA: 0x0000C078 File Offset: 0x0000A278
		// (set) Token: 0x06003BC8 RID: 15304 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000BCB")]
		public bool IgnoreAchieved
		{
			[Token(Token = "0x6003BC7")]
			[Address(RVA = "0x8A9B", Offset = "0x8A9B", VA = "0x8A9B")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6003BC8")]
			[Address(RVA = "0x8A9C", Offset = "0x8A9C", VA = "0x8A9C")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000BCC RID: 3020
		// (get) Token: 0x06003BC9 RID: 15305 RVA: 0x0000C090 File Offset: 0x0000A290
		// (set) Token: 0x06003BCA RID: 15306 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000BCC")]
		public bool Achieved
		{
			[Token(Token = "0x6003BC9")]
			[Address(RVA = "0x8A9D", Offset = "0x8A9D", VA = "0x8A9D")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6003BCA")]
			[Address(RVA = "0x8A9E", Offset = "0x8A9E", VA = "0x8A9E")]
			set
			{
			}
		}

		// Token: 0x06003BCB RID: 15307 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003BCB")]
		[Address(RVA = "0x8A9F", Offset = "0x8A9F", VA = "0x8A9F")]
		private void HandleAchivedChanged()
		{
		}

		// Token: 0x06003BCC RID: 15308 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003BCC")]
		[Address(RVA = "0x8AA0", Offset = "0x8AA0", VA = "0x8AA0")]
		public CollectionIconView()
		{
		}

		// Token: 0x040020E7 RID: 8423
		[Token(Token = "0x40020E7")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private GameRawImage _rankFrame;

		// Token: 0x040020E8 RID: 8424
		[Token(Token = "0x40020E8")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private GameRawImage _ribbon;

		// Token: 0x040020E9 RID: 8425
		[Token(Token = "0x40020E9")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameRawImage _rankbackground;

		// Token: 0x040020EA RID: 8426
		[Token(Token = "0x40020EA")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private GameAssetViewRawImage _iconAssetView;

		// Token: 0x040020EB RID: 8427
		[Token(Token = "0x40020EB")]
		private const int MEDAL_ICON_SIZE = 64;

		// Token: 0x040020EC RID: 8428
		[Token(Token = "0x40020EC")]
		private const int APR_ICON_SIZE = 90;

		// Token: 0x040020ED RID: 8429
		[Token(Token = "0x40020ED")]
		private const int DEFAULT_SIZE = 128;

		// Token: 0x040020EE RID: 8430
		[Token(Token = "0x40020EE")]
		[FieldOffset(Offset = "0x20")]
		private IDictProvider _dictProvider;

		// Token: 0x040020EF RID: 8431
		[Token(Token = "0x40020EF")]
		[FieldOffset(Offset = "0x24")]
		private UserData _user;

		// Token: 0x040020F1 RID: 8433
		[Token(Token = "0x40020F1")]
		[FieldOffset(Offset = "0x2C")]
		private uint _rank;

		// Token: 0x040020F3 RID: 8435
		[Token(Token = "0x40020F3")]
		[FieldOffset(Offset = "0x31")]
		private bool _achieved;
	}
}
