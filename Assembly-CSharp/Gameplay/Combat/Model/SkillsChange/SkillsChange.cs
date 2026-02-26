using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Protocol.Combat;

namespace Gameplay.Combat.Model.SkillsChange
{
	// Token: 0x020009A6 RID: 2470
	[Token(Token = "0x20009A6")]
	public class SkillsChange : ISkillsChange, IDisposable
	{
		// Token: 0x17000BB6 RID: 2998
		// (get) Token: 0x06003AFE RID: 15102 RVA: 0x0000BEC8 File Offset: 0x0000A0C8
		[Token(Token = "0x17000BB6")]
		public ulong UserId
		{
			[Token(Token = "0x6003AFE")]
			[Address(RVA = "0x8A69", Offset = "0x8A69", VA = "0x8A69", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return 0UL;
			}
		}

		// Token: 0x17000BB7 RID: 2999
		// (get) Token: 0x06003AFF RID: 15103 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06003B00 RID: 15104 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000BB7")]
		public IList<PlayerSkill> Skills
		{
			[Token(Token = "0x6003AFF")]
			[Address(RVA = "0x8A6A", Offset = "0x8A6A", VA = "0x8A6A", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003B00")]
			[Address(RVA = "0x8A6B", Offset = "0x8A6B", VA = "0x8A6B")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000BB8 RID: 3000
		// (get) Token: 0x06003B01 RID: 15105 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06003B02 RID: 15106 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000BB8")]
		public IShortSpellInfo[] SpellsChanges
		{
			[Token(Token = "0x6003B01")]
			[Address(RVA = "0x8A6C", Offset = "0x8A6C", VA = "0x8A6C", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003B02")]
			[Address(RVA = "0x8A6D", Offset = "0x8A6D", VA = "0x8A6D")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06003B03 RID: 15107 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003B03")]
		[Address(RVA = "0x8A6E", Offset = "0x8A6E", VA = "0x8A6E", Slot = "7")]
		public void Dispose()
		{
		}

		// Token: 0x06003B04 RID: 15108 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003B04")]
		[Address(RVA = "0x8A6F", Offset = "0x8A6F", VA = "0x8A6F")]
		public SkillsChange(ulong userId, IList<PlayerSkill> skills, IShortSpellInfo[] spellInfo)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Combat_Model_SkillsChange_SkillsChange___ctor
		               (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  if (DAT_ram_00a57e58 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_Model_FieldChange_AbstractFieldChangeDecorator_ProtoFieldChangedEvt___ctor__
		              );
		    DAT_ram_00a57e58 = '\x01';
		  }
		  Unity_Services_Core_Environments_Internal_Environments__get_Current
		            (param1,param2,
		             Method_Gameplay_Combat_Model_FieldChange_AbstractFieldChangeDecorator_ProtoFieldChangedEvt___ctor__
		            );
		  return;
		}
		*/

		}
	}
}
