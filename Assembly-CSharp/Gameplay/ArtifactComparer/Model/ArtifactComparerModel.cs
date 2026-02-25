using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Data;
using Gameplay.Inventory.Model;
using Il2CppDummyDll;
using MVC;

namespace Gameplay.ArtifactComparer.Model
{
	// Token: 0x02000CE4 RID: 3300
	[Token(Token = "0x2000CE4")]
	public class ArtifactComparerModel : AbstractModel
	{
		// Token: 0x17001040 RID: 4160
		// (get) Token: 0x06005050 RID: 20560 RVA: 0x0000EB68 File Offset: 0x0000CD68
		// (set) Token: 0x06005051 RID: 20561 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001040")]
		public bool DebugMode
		{
			[Token(Token = "0x6005050")]
			[Address(RVA = "0x9E61", Offset = "0x9E61", VA = "0x9E61")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6005051")]
			[Address(RVA = "0x9E62", Offset = "0x9E62", VA = "0x9E62")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17001041 RID: 4161
		// (get) Token: 0x06005052 RID: 20562 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06005053 RID: 20563 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001041")]
		public InventoryBaseModel InventoryModel
		{
			[Token(Token = "0x6005052")]
			[Address(RVA = "0x9E63", Offset = "0x9E63", VA = "0x9E63")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6005053")]
			[Address(RVA = "0x9E64", Offset = "0x9E64", VA = "0x9E64")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17001042 RID: 4162
		// (get) Token: 0x06005054 RID: 20564 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06005055 RID: 20565 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001042")]
		public ArtifactData TargetArtifact
		{
			[Token(Token = "0x6005054")]
			[Address(RVA = "0x9E65", Offset = "0x9E65", VA = "0x9E65")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6005055")]
			[Address(RVA = "0x9E66", Offset = "0x9E66", VA = "0x9E66")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17001043 RID: 4163
		// (get) Token: 0x06005056 RID: 20566 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06005057 RID: 20567 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001043")]
		public ArtifactData ComparableArtifact
		{
			[Token(Token = "0x6005056")]
			[Address(RVA = "0x9E67", Offset = "0x9E67", VA = "0x9E67")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6005057")]
			[Address(RVA = "0x9E68", Offset = "0x9E68", VA = "0x9E68")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17001044 RID: 4164
		// (get) Token: 0x06005058 RID: 20568 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06005059 RID: 20569 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001044")]
		public List<int> AllSkillIds
		{
			[Token(Token = "0x6005058")]
			[Address(RVA = "0x9E69", Offset = "0x9E69", VA = "0x9E69")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6005059")]
			[Address(RVA = "0x9E6A", Offset = "0x9E6A", VA = "0x9E6A")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17001045 RID: 4165
		// (get) Token: 0x0600505A RID: 20570 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600505B RID: 20571 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001045")]
		public HashSet<int> EnabledSkillIds
		{
			[Token(Token = "0x600505A")]
			[Address(RVA = "0x9E6B", Offset = "0x9E6B", VA = "0x9E6B")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600505B")]
			[Address(RVA = "0x9E6C", Offset = "0x9E6C", VA = "0x9E6C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0600505C RID: 20572 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600505C")]
		[Address(RVA = "0x9E6D", Offset = "0x9E6D", VA = "0x9E6D")]
		public ArtifactComparerModel(UserData user, InventoryBaseModel inventoryModel)
		{
		}

		// Token: 0x0600505D RID: 20573 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600505D")]
		[Address(RVA = "0x9E6E", Offset = "0x9E6E", VA = "0x9E6E")]
		private void InitSkillIds()
		{
		}

		// Token: 0x0600505E RID: 20574 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600505E")]
		[Address(RVA = "0x9E6F", Offset = "0x9E6F", VA = "0x9E6F")]
		public void SetTargetArtifact(ArtifactData artifactData)
		{
		}

		// Token: 0x0600505F RID: 20575 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600505F")]
		[Address(RVA = "0x9E70", Offset = "0x9E70", VA = "0x9E70", Slot = "5")]
		public override void Dispose()
		{
		}

		// Token: 0x06005060 RID: 20576 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005060")]
		[Address(RVA = "0x9E71", Offset = "0x9E71", VA = "0x9E71")]
		public void SetDebugMode(bool debug)
		{
		}
	}
}
