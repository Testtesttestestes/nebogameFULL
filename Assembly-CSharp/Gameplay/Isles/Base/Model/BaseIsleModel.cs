using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Data;
using Core.Dict;
using Core.Gameplay;
using Gameplay.Discounts.Model;
using Gameplay.World.Model;
using Il2CppDummyDll;
using JetBrains.Annotations;
using MVC;
using Protocol.Dic;

namespace Gameplay.Isles.Base.Model
{
	// Token: 0x02000CFD RID: 3325
	[Token(Token = "0x2000CFD")]
	public class BaseIsleModel : AbstractModel
	{
		// Token: 0x1700106C RID: 4204
		// (get) Token: 0x0600511E RID: 20766 RVA: 0x0000ECE8 File Offset: 0x0000CEE8
		[Token(Token = "0x1700106C")]
		public ulong Id
		{
			[Token(Token = "0x600511E")]
			[Address(RVA = "0x9F0E", Offset = "0x9F0E", VA = "0x9F0E")]
			[CompilerGenerated]
			get
			{
				return 0UL;
			}
		}

		// Token: 0x1700106D RID: 4205
		// (get) Token: 0x0600511F RID: 20767 RVA: 0x0000ED00 File Offset: 0x0000CF00
		// (set) Token: 0x06005120 RID: 20768 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700106D")]
		public bool IsDisposed
		{
			[Token(Token = "0x600511F")]
			[Address(RVA = "0x9F0F", Offset = "0x9F0F", VA = "0x9F0F")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6005120")]
			[Address(RVA = "0x9F10", Offset = "0x9F10", VA = "0x9F10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700106E RID: 4206
		// (get) Token: 0x06005121 RID: 20769 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06005122 RID: 20770 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700106E")]
		public IDictProvider DictProvider
		{
			[Token(Token = "0x6005121")]
			[Address(RVA = "0x9F11", Offset = "0x9F11", VA = "0x9F11")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6005122")]
			[Address(RVA = "0x9F12", Offset = "0x9F12", VA = "0x9F12")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700106F RID: 4207
		// (get) Token: 0x06005123 RID: 20771 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700106F")]
		public Dictionaries Dictionaries
		{
			[Token(Token = "0x6005123")]
			[Address(RVA = "0x9F13", Offset = "0x9F13", VA = "0x9F13")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001070 RID: 4208
		// (get) Token: 0x06005124 RID: 20772 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06005125 RID: 20773 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001070")]
		[CanBeNull]
		public IDiscountHandler DiscountHandler
		{
			[Token(Token = "0x6005124")]
			[Address(RVA = "0x9F14", Offset = "0x9F14", VA = "0x9F14")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6005125")]
			[Address(RVA = "0x9F15", Offset = "0x9F15", VA = "0x9F15")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17001071 RID: 4209
		// (get) Token: 0x06005126 RID: 20774 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06005127 RID: 20775 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001071")]
		public Dictionary<uint, BaseBuildingData> Buildings
		{
			[Token(Token = "0x6005126")]
			[Address(RVA = "0x9F16", Offset = "0x9F16", VA = "0x9F16")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6005127")]
			[Address(RVA = "0x9F17", Offset = "0x9F17", VA = "0x9F17")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17001072 RID: 4210
		// (get) Token: 0x06005128 RID: 20776 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06005129 RID: 20777 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001072")]
		public IGame Game
		{
			[Token(Token = "0x6005128")]
			[Address(RVA = "0x9F18", Offset = "0x9F18", VA = "0x9F18")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6005129")]
			[Address(RVA = "0x9F19", Offset = "0x9F19", VA = "0x9F19")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0600512A RID: 20778 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600512A")]
		[Address(RVA = "0x9F1A", Offset = "0x9F1A", VA = "0x9F1A")]
		public BaseIsleModel(UserData user, ulong id, IDictProvider dictionaries, IGame game)
		{
		}

		// Token: 0x0600512B RID: 20779 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600512B")]
		[Address(RVA = "0x9F1B", Offset = "0x9F1B", VA = "0x9F1B", Slot = "5")]
		public override void Dispose()
		{
		}

		// Token: 0x17001073 RID: 4211
		// (get) Token: 0x0600512C RID: 20780 RVA: 0x0000ED18 File Offset: 0x0000CF18
		// (set) Token: 0x0600512D RID: 20781 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001073")]
		public bool IsCurrentIsle
		{
			[Token(Token = "0x600512C")]
			[Address(RVA = "0x9F1C", Offset = "0x9F1C", VA = "0x9F1C")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600512D")]
			[Address(RVA = "0x9F1D", Offset = "0x9F1D", VA = "0x9F1D")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0600512E RID: 20782 RVA: 0x0000ED30 File Offset: 0x0000CF30
		[Token(Token = "0x600512E")]
		[Address(RVA = "0x9F1E", Offset = "0x9F1E", VA = "0x9F1E")]
		public uint GetBuildingLevel(uint typeId)
		{
			return 0U;
		}

		// Token: 0x0600512F RID: 20783 RVA: 0x0000ED48 File Offset: 0x0000CF48
		[Token(Token = "0x600512F")]
		[Address(RVA = "0x9F1F", Offset = "0x9F1F", VA = "0x9F1F")]
		public bool TryGetConstructedBuilding(uint buildingType, out BaseBuildingData building)
		{
			return default(bool);
		}
	}
}
