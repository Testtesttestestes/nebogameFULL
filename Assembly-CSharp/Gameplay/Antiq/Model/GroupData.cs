using System;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using JetBrains.Annotations;
using Protocol.Dic;

namespace Gameplay.Antiq.Model
{
	// Token: 0x02000D94 RID: 3476
	[Token(Token = "0x2000D94")]
	internal class GroupData
	{
		// Token: 0x1700114F RID: 4431
		// (get) Token: 0x06005506 RID: 21766 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06005507 RID: 21767 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700114F")]
		[CanBeNull]
		public ArtifactData CurrentAchieved
		{
			[Token(Token = "0x6005506")]
			[Address(RVA = "0xA2AB", Offset = "0xA2AB", VA = "0xA2AB")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6005507")]
			[Address(RVA = "0xA2AC", Offset = "0xA2AC", VA = "0xA2AC")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06005508 RID: 21768 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005508")]
		[Address(RVA = "0xA2AD", Offset = "0xA2AD", VA = "0xA2AD")]
		public GroupData(int index, Antiq.Types.ArtifactGroupsDic artifactGroupsDic, ReadOnlyCollection<ArtifactData> artifacts, CategoryData category)
		{
		/* --- GHIDRA: .ctor ---
		undefined4 Gameplay_Antiq_Model_GroupData___ctor(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  int iVar2;
		  undefined4 uVar3;
		  
		  if (DAT_ram_00a587fa == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_First_ArtifactData___);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_Last_ArtifactData___);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_ObjectModel_ReadOnlyCollection_ArtifactData__IndexOf__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_ObjectModel_ReadOnlyCollection_ArtifactData__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_ObjectModel_ReadOnlyCollection_ArtifactData__get_Item__);
		    DAT_ram_00a587fa = '\x01';
		  }
		  if (*(int *)(param1 + 0x18) == 0) {
		    uVar3 = System_Linq_Enumerable__Count_object_
		                      (*(undefined4 *)(param1 + 8),
		                       Method_System_Linq_Enumerable_First_ArtifactData___);
		    return uVar3;
		  }
		  iVar1 = System_Collections_ObjectModel_ReadOnlyCollection_UsageHint___GetEnumerator
		                    (*(undefined4 *)(param1 + 8),*(int *)(param1 + 0x18),
		                     Method_System_Collections_ObjectModel_ReadOnlyCollection_ArtifactData__IndexOf__
		                    );
		  iVar2 = Sirenix_Utilities_ImmutableList___Il2CppFullySharedGenericType___System_Collections_IList_set_Item
		                    (*(undefined4 *)(param1 + 8),
		                     Method_System_Collections_ObjectModel_ReadOnlyCollection_ArtifactData__get_Count__
		                    );
		  if (iVar1 + 1 <= iVar2 + -1) {
		    uVar3 = System_Collections_ObjectModel_ReadOnlyDictionary_object__object___get_Count
		                      (*(undefined4 *)(param1 + 8),iVar1 + 1,
		                       Method_System_Collections_ObjectModel_ReadOnlyCollection_ArtifactData__get_Item__
		                      );
		    return uVar3;
		  }
		  uVar3 = System_Linq_Enumerable__IntersectIterator___Il2CppFullySharedGenericType_
		                    (*(undefined4 *)(param1 + 8),Method_System_Linq_Enumerable_Last_ArtifactData___)
		  ;
		  return uVar3;
		}
		*/

		}

		// Token: 0x06005509 RID: 21769 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005509")]
		[Address(RVA = "0xA2AE", Offset = "0xA2AE", VA = "0xA2AE")]
		public ArtifactData GetArtifact()
		{
		/* --- GHIDRA: GetArtifact ---
		undefined8 Gameplay_Antiq_Model_GroupData__GetArtifact(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a587fb == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_First_ArtifactData___);
		    DAT_ram_00a587fb = '\x01';
		  }
		  iVar1 = *(int *)(param1 + 0x18);
		  if (iVar1 == 0) {
		    iVar1 = System_Linq_Enumerable__Count_object_
		                      (*(undefined4 *)(param1 + 8),
		                       Method_System_Linq_Enumerable_First_ArtifactData___);
		  }
		  return *(undefined8 *)(*(int *)(iVar1 + 0xc) + 0x20);
		}
		*/

			return null;
		}

		// Token: 0x0600550A RID: 21770 RVA: 0x0000F618 File Offset: 0x0000D818
		[Token(Token = "0x600550A")]
		[Address(RVA = "0xA2AF", Offset = "0xA2AF", VA = "0xA2AF")]
		public ulong GetLevel()
		{
		/* --- GHIDRA: GetLevel ---
		undefined4 Gameplay_Antiq_Model_GroupData__GetLevel(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a587fd == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_ObjectModel_ReadOnlyCollection_ArtifactData__Contains__);
		    DAT_ram_00a587fd = '\x01';
		  }
		  uVar1 = System_Collections_ObjectModel_ReadOnlyCollection_ushort___get_Item
		                    (*(undefined4 *)(param1 + 8),*(undefined4 *)(param1 + 0x18),
		                     Method_System_Collections_ObjectModel_ReadOnlyCollection_ArtifactData__Contains__
		                    );
		  return uVar1;
		}
		*/

			return 0UL;
		}

		// Token: 0x0600550B RID: 21771 RVA: 0x0000F630 File Offset: 0x0000D830
		[Token(Token = "0x600550B")]
		[Address(RVA = "0x1D29", Offset = "0x1D29", VA = "0x1D29")]
		public bool IsComplete()
		{
		/* --- GHIDRA: IsComplete ---
		void Gameplay_Antiq_Model_GroupData__IsComplete(int param1,uint param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  int iVar2;
		  
		  iVar2 = *(int *)(param1 + 0x1c);
		  if (0 < *(int *)(iVar2 + 0xc)) {
		    iVar1 = 0;
		    do {
		      param1_00 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                            (*(undefined4 *)(iVar2 + iVar1 * 4 + 0x10),0);
		      Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		                (param1_00,param2 ^ 1,0);
		      iVar1 = iVar1 + 1;
		    } while (iVar1 < *(int *)(iVar2 + 0xc));
		  }
		  return;
		}
		*/

			return default(bool);
		}

		// Token: 0x0600550C RID: 21772 RVA: 0x0000F648 File Offset: 0x0000D848
		[Token(Token = "0x600550C")]
		[Address(RVA = "0xA2B0", Offset = "0xA2B0", VA = "0xA2B0")]
		public bool IsAchieved()
		{
		/* --- GHIDRA: IsAchieved ---
		void Gameplay_Antiq_Model_GroupData__IsAchieved
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4,undefined4 param5)
		
		{
		  if (DAT_ram_00a587fe == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_MVC_AbstractController_AntiqModel__AntiqEvents___ctor__);
		    DAT_ram_00a587fe = '\x01';
		  }
		  Gameplay_Combat_AbstractCombat_object__object__object__object__object___set_User
		            (param1,param2,param3,Method_MVC_AbstractController_AntiqModel__AntiqEvents___ctor__);
		  *(undefined4 *)(param1 + 0x18) = param4;
		  return;
		}
		*/

			return default(bool);
		}

		// Token: 0x04002E13 RID: 11795
		[Token(Token = "0x4002E13")]
		[FieldOffset(Offset = "0x8")]
		public readonly ReadOnlyCollection<ArtifactData> Artifacts;

		// Token: 0x04002E14 RID: 11796
		[Token(Token = "0x4002E14")]
		[FieldOffset(Offset = "0xC")]
		public readonly Antiq.Types.ArtifactGroupsDic ArtifactGroupsDic;

		// Token: 0x04002E15 RID: 11797
		[Token(Token = "0x4002E15")]
		[FieldOffset(Offset = "0x10")]
		public readonly CategoryData Category;

		// Token: 0x04002E16 RID: 11798
		[Token(Token = "0x4002E16")]
		[FieldOffset(Offset = "0x14")]
		public readonly int Index;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_CurrentAchieved ---
		void Gameplay_Antiq_Model_GroupData__set_CurrentAchieved
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4,undefined4 param5,
		               undefined4 param6)
		
		{
		  *(undefined4 *)(param1 + 0xc) = param3;
		  *(undefined4 *)(param1 + 0x14) = param2;
		  *(undefined4 *)(param1 + 0x10) = param5;
		  *(undefined4 *)(param1 + 8) = param4;
		  return;
		}
		*/

}
