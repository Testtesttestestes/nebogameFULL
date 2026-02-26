using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Core.Gameplay.Managers.Requirements.ListFillBehaviors;
using Il2CppDummyDll;
using Protocol.Dic;

namespace Core.Data.InfoRows
{
	// Token: 0x020010DB RID: 4315
	[Token(Token = "0x20010DB")]
	public abstract class AbstractInformationProvider : IInformationProvider, IDisposable
	{
		// Token: 0x17001473 RID: 5235
		// (get) Token: 0x06006508 RID: 25864 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06006509 RID: 25865 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001473")]
		public UserData LoggedUser
		{
			[Token(Token = "0x6006508")]
			[Address(RVA = "0xB0DF", Offset = "0xB0DF", VA = "0xB0DF", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006509")]
			[Address(RVA = "0xB0E0", Offset = "0xB0E0", VA = "0xB0E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17001474 RID: 5236
		// (get) Token: 0x0600650A RID: 25866 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600650B RID: 25867 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001474")]
		public IListFillBehavior ListFillBehavior
		{
			[Token(Token = "0x600650A")]
			[Address(RVA = "0xB0E1", Offset = "0xB0E1", VA = "0xB0E1")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600650B")]
			[Address(RVA = "0xB0E2", Offset = "0xB0E2", VA = "0xB0E2")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0600650C RID: 25868 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600650C")]
		[Address(RVA = "0xB0E3", Offset = "0xB0E3", VA = "0xB0E3", Slot = "7")]
		public virtual void Dispose()
		{
		/* --- GHIDRA: Dispose ---
		void Core_Data_InfoRows_AbstractInformationProvider__Dispose
		               (int param1,undefined4 param2,int param3,undefined4 param4)
		
		{
		  uint uVar1;
		  undefined4 uVar2;
		  uint *puVar3;
		  int *param1_00;
		  int iVar4;
		  
		  if (DAT_ram_00a60838 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Core_Gameplay_Managers_Requirements_ListFillBehaviors_DefaultListFillBehavior_TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_IInformationRow___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_IInformationRow__TypeInfo);
		    DAT_ram_00a60838 = '\x01';
		  }
		  uVar2 = unnamed_function_1417(System_Collections_Generic_List_IInformationRow__TypeInfo);
		  Unity_Services_Core_Internal_UnityServicesInternal___c__DisplayClass33_0___InitializeServicesAsync_g__FailServicesInitialization_2
		            (uVar2,0x14,Method_System_Collections_Generic_List_IInformationRow___ctor__);
		  *(undefined4 *)(param1 + 8) = uVar2;
		  *(undefined4 *)(param1 + 0xc) = param2;
		  if (param3 == 0) {
		    param3 = unnamed_function_1417
		                       (
		                       Core_Gameplay_Managers_Requirements_ListFillBehaviors_DefaultListFillBehavior_TypeInfo
		                       );
		  }
		  *(int *)(param1 + 0x10) = param3;
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  param1_00 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar4 = *param1_00;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0x178);
		        goto code_r0x81cece7a;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x81cece7a:
		  uVar2 = (**(code **)((ulonglong)*puVar3 * 4))(param1_00,puVar3[1]);
		  uVar2 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System(uVar2,0);
		  *(undefined4 *)(param1 + 0x14) = uVar2;
		  return;
		}
		*/

		}

		// Token: 0x0600650D RID: 25869 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600650D")]
		[Address(RVA = "0xB0E4", Offset = "0xB0E4", VA = "0xB0E4")]
		protected AbstractInformationProvider(UserData loggedUser, [Optional] IListFillBehavior listFillBehavior)
		{
		/* --- GHIDRA: .ctor ---
		undefined4
		Core_Data_InfoRows_AbstractInformationProvider___ctor
		          (undefined4 param1,undefined4 param2,int param3,undefined4 param4)
		
		{
		  if (DAT_ram_00a60839 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_IInformationRow__AddRange__);
		    DAT_ram_00a60839 = '\x01';
		  }
		  if (param3 != 0) {
		    func_ii_6335(param2,param3,Method_System_Collections_Generic_List_IInformationRow__AddRange__);
		  }
		  return param2;
		}
		*/

		}

		// Token: 0x0600650E RID: 25870 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600650E")]
		[Address(RVA = "0xB0E5", Offset = "0xB0E5", VA = "0xB0E5")]
		protected List<IInformationRow> Merge(List<IInformationRow> a, List<IInformationRow> b)
		{
		/* --- GHIDRA: Merge ---
		int Core_Data_InfoRows_AbstractInformationProvider__Merge
		              (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a6083a == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Data_InfoRows_CommonRow_TypeInfo);
		    DAT_ram_00a6083a = '\x01';
		  }
		  iVar1 = unnamed_function_1417(Core_Data_InfoRows_CommonRow_TypeInfo);
		  *(undefined4 *)(iVar1 + 0xc) = param2;
		  return iVar1;
		}
		*/

			return null;
		}

		// Token: 0x0600650F RID: 25871 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600650F")]
		[Address(RVA = "0xB0E6", Offset = "0xB0E6", VA = "0xB0E6", Slot = "8")]
		public virtual CommonRow GetTitle(string text)
		{
		/* --- GHIDRA: GetTitle ---
		int Core_Data_InfoRows_AbstractInformationProvider__GetTitle(int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  int param3;
		  
		  if (DAT_ram_00a6083b == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_IInformationRow__Clear__);
		    DAT_ram_00a6083b = '\x01';
		  }
		  iVar1 = param1[2];
		  param3 = *(int *)(iVar1 + 0xc);
		  *(undefined4 *)(iVar1 + 0xc) = 0;
		  *(int *)(iVar1 + 0x10) = *(int *)(iVar1 + 0x10) + 1;
		  if (0 < param3) {
		    func_ii_2064(*(undefined4 *)(iVar1 + 8),0,param3,0);
		  }
		  (**(code **)((ulonglong)*(uint *)(*param1 + 0x108) * 4))(param1,*(undefined4 *)(*param1 + 0x10c));
		  return param1[2];
		}
		*/

			return null;
		}

		// Token: 0x06006510 RID: 25872 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6006510")]
		[Address(RVA = "0xB0E7", Offset = "0xB0E7", VA = "0xB0E7", Slot = "5")]
		public List<IInformationRow> GetRows()
		{
			return null;
		}

		// Token: 0x06006511 RID: 25873
		[Token(Token = "0x6006511")]
		protected abstract void PrepareInformation();

		// Token: 0x040035FA RID: 13818
		[Token(Token = "0x40035FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		protected readonly List<IInformationRow> _rows;

		// Token: 0x040035FD RID: 13821
		[Token(Token = "0x40035FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		protected Dictionaries _dictionaries;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_ListFillBehavior ---
		void Core_Data_InfoRows_AbstractInformationProvider__set_ListFillBehavior
		               (int param1,undefined4 param2)
		
		{
		  int iVar1;
		  int param3;
		  
		  if (DAT_ram_00a60837 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_IInformationRow__Clear__);
		    DAT_ram_00a60837 = '\x01';
		  }
		  iVar1 = *(int *)(param1 + 8);
		  param3 = *(int *)(iVar1 + 0xc);
		  *(undefined4 *)(iVar1 + 0xc) = 0;
		  *(int *)(iVar1 + 0x10) = *(int *)(iVar1 + 0x10) + 1;
		  if (0 < param3) {
		    func_ii_2064(*(undefined4 *)(iVar1 + 8),0,param3,0);
		  }
		  *(undefined4 *)(param1 + 0x14) = 0;
		  *(undefined8 *)(param1 + 0xc) = 0;
		  return;
		}
		*/

}
