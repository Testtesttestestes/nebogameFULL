using System;
using System.Runtime.CompilerServices;
using Core.Data;
using Il2CppDummyDll;

namespace Gameplay.Combat.Model
{
	// Token: 0x0200099E RID: 2462
	[Token(Token = "0x200099E")]
	public class PetData : IDisposable
	{
		// Token: 0x17000BA7 RID: 2983
		// (get) Token: 0x06003AE0 RID: 15072 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06003AE1 RID: 15073 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000BA7")]
		public ArtifactData Artifact
		{
			[Token(Token = "0x6003AE0")]
			[Address(RVA = "0x8A55", Offset = "0x8A55", VA = "0x8A55")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003AE1")]
			[Address(RVA = "0x8A56", Offset = "0x8A56", VA = "0x8A56")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000BA8 RID: 2984
		// (get) Token: 0x06003AE2 RID: 15074 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000BA8")]
		public string Title
		{
			[Token(Token = "0x6003AE2")]
			[Address(RVA = "0x8A57", Offset = "0x8A57", VA = "0x8A57")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000BA9 RID: 2985
		// (get) Token: 0x06003AE3 RID: 15075 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06003AE4 RID: 15076 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000BA9")]
		public CombatPlayer Player
		{
			[Token(Token = "0x6003AE3")]
			[Address(RVA = "0x8A58", Offset = "0x8A58", VA = "0x8A58")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003AE4")]
			[Address(RVA = "0x8A59", Offset = "0x8A59", VA = "0x8A59")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06003AE5 RID: 15077 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003AE5")]
		[Address(RVA = "0x8A5A", Offset = "0x8A5A", VA = "0x8A5A", Slot = "1")]
		protected override void Finalize()
		{
		}

		// Token: 0x06003AE6 RID: 15078 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003AE6")]
		[Address(RVA = "0x8A5B", Offset = "0x8A5B", VA = "0x8A5B")]
		public PetData(ArtifactData artifact, CombatPlayer player)
		{
		/* --- GHIDRA: .ctor ---
		undefined8 Gameplay_Combat_Model_PetData___ctor(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  iVar1 = *(int *)(param1 + 0xc);
		  if (DAT_ram_00a57e48 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_int__Skill__get_Item__);
		    DAT_ram_00a57e48 = '\x01';
		  }
		  iVar1 = System_Collections_Generic_Dictionary_int__Int32Enum___get_Count
		                    (*(undefined4 *)(iVar1 + 0x58),0,
		                     Method_System_Collections_Generic_Dictionary_int__Skill__get_Item__);
		  return *(undefined8 *)(iVar1 + 0x10);
		}
		*/

		}

		// Token: 0x17000BAA RID: 2986
		// (get) Token: 0x06003AE7 RID: 15079 RVA: 0x0000BE80 File Offset: 0x0000A080
		[Token(Token = "0x17000BAA")]
		public long CurrentHeal
		{
			[Token(Token = "0x6003AE7")]
			[Address(RVA = "0x8A5C", Offset = "0x8A5C", VA = "0x8A5C")]
			get
			{
				return 0L;
			}
		}

		// Token: 0x17000BAB RID: 2987
		// (get) Token: 0x06003AE8 RID: 15080 RVA: 0x0000BE98 File Offset: 0x0000A098
		[Token(Token = "0x17000BAB")]
		public long TotalHeal
		{
			[Token(Token = "0x6003AE8")]
			[Address(RVA = "0x8A5D", Offset = "0x8A5D", VA = "0x8A5D")]
			get
			{
				return 0L;
			}
		}

		// Token: 0x06003AE9 RID: 15081 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003AE9")]
		[Address(RVA = "0x8A5E", Offset = "0x8A5E", VA = "0x8A5E", Slot = "4")]
		public void Dispose()
		{
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_Artifact ---
		undefined4 Gameplay_Combat_Model_PetData__set_Artifact(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a57e54 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Dict_DictWrappers_Base_AbstractDictWrapper_ArtikulDic__uint__get_Data__)
		    ;
		    DAT_ram_00a57e54 = '\x01';
		  }
		  uVar1 = Core_Extensions_Dict_DictExt__GetArtikul
		                    (*(undefined4 *)(*(int *)(*(int *)(param1 + 8) + 8) + 0x10),0);
		  return uVar1;
		}
		*/


		/* --- GHIDRA: get_CurrentHeal ---
		undefined8 Gameplay_Combat_Model_PetData__get_CurrentHeal(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  iVar1 = *(int *)(param1 + 0xc);
		  if (DAT_ram_00a57e49 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_int__Skill__get_Item__);
		    DAT_ram_00a57e49 = '\x01';
		  }
		  iVar1 = System_Collections_Generic_Dictionary_int__Int32Enum___get_Count
		                    (*(undefined4 *)(iVar1 + 0x58),0xe,
		                     Method_System_Collections_Generic_Dictionary_int__Skill__get_Item__);
		  return *(undefined8 *)(iVar1 + 0x10);
		}
		*/

}
