using System;
using System.Runtime.CompilerServices;
using Core.Application;
using Core.Gameplay;
using Gameplay.School.Model;
using Il2CppDummyDll;

namespace Core.Events.Scopes
{
	// Token: 0x02001023 RID: 4131
	[Token(Token = "0x2001023")]
	public class SchoolScope : AbstractEventBusScope
	{
		// Token: 0x0600619F RID: 24991 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600619F")]
		[Address(RVA = "0xADCA", Offset = "0xADCA", VA = "0xADCA", Slot = "5")]
		public override void Dispose()
		{
		}

		// Token: 0x060061A0 RID: 24992 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60061A0")]
		[Address(RVA = "0xADCB", Offset = "0xADCB", VA = "0xADCB")]
		public SchoolScope()
		{
		}

		// Token: 0x04003477 RID: 13431
		[Token(Token = "0x4003477")]
		[FieldOffset(Offset = "0x8")]
		public Action<SchoolScope.SchoolEventArgs> StartLearnEvent;

		// Token: 0x04003478 RID: 13432
		[Token(Token = "0x4003478")]
		[FieldOffset(Offset = "0xC")]
		public Action<SchoolScope.SchoolEventArgs> CancelLearnEvent;

		// Token: 0x04003479 RID: 13433
		[Token(Token = "0x4003479")]
		[FieldOffset(Offset = "0x10")]
		public Action<SchoolScope.SchoolEventArgs> AccelerateLearnEvent;

		// Token: 0x02001024 RID: 4132
		[Token(Token = "0x2001024")]
		public class SchoolEventArgs : BaseEventBusEventArgs
		{
			// Token: 0x17001373 RID: 4979
			// (get) Token: 0x060061A1 RID: 24993 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x17001373")]
			public SchoolSpellData SchoolSpellData
			{
				[Token(Token = "0x60061A1")]
				[Address(RVA = "0xADCC", Offset = "0xADCC", VA = "0xADCC")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			// Token: 0x17001374 RID: 4980
			// (get) Token: 0x060061A2 RID: 24994 RVA: 0x00011F70 File Offset: 0x00010170
			[Token(Token = "0x17001374")]
			public ulong OwnerId
			{
				[Token(Token = "0x60061A2")]
				[Address(RVA = "0xADCD", Offset = "0xADCD", VA = "0xADCD")]
				[CompilerGenerated]
				get
				{
					return 0UL;
				}
			}

			// Token: 0x060061A3 RID: 24995 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60061A3")]
			[Address(RVA = "0xADCE", Offset = "0xADCE", VA = "0xADCE")]
			public SchoolEventArgs(App app, IGame game, SchoolSpellData schoolSpellData, ulong ownerId)
			{
			}
		}
	}
}
