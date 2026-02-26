using System;
using System.Runtime.CompilerServices;
using Gameplay.MageSchool.Events;
using Gameplay.School.Controller;
using Gameplay.School.Model;
using Il2CppDummyDll;
using UI.Elements.Buildings;
using UnityEngine;
using UnityEngine.UI;

namespace UI.Windows.Buildings.MageSchoolWindow
{
	// Token: 0x020002BC RID: 700
	[Token(Token = "0x20002BC")]
	public class SchoolWindow2 : ClosableBaseWindow<SchoolWindowArgs>
	{
		// Token: 0x17000267 RID: 615
		// (get) Token: 0x06001074 RID: 4212 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000267")]
		public override string WindowId
		{
			[Token(Token = "0x6001074")]
			[Address(RVA = "0x6271", Offset = "0x6271", VA = "0x6271", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x14000103 RID: 259
		// (add) Token: 0x06001075 RID: 4213 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06001076 RID: 4214 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000103")]
		public event Action<uint> OnSelectSpell
		{
			[Token(Token = "0x6001075")]
			[Address(RVA = "0x6272", Offset = "0x6272", VA = "0x6272")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6001076")]
			[Address(RVA = "0x6273", Offset = "0x6273", VA = "0x6273")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000104 RID: 260
		// (add) Token: 0x06001077 RID: 4215 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06001078 RID: 4216 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000104")]
		public event Action<uint> OnDeselectSpell
		{
			[Token(Token = "0x6001077")]
			[Address(RVA = "0x6274", Offset = "0x6274", VA = "0x6274")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6001078")]
			[Address(RVA = "0x6275", Offset = "0x6275", VA = "0x6275")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x17000268 RID: 616
		// (get) Token: 0x06001079 RID: 4217 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000268")]
		public SpellList NeutralSpellsList
		{
			[Token(Token = "0x6001079")]
			[Address(RVA = "0x6276", Offset = "0x6276", VA = "0x6276")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000269 RID: 617
		// (get) Token: 0x0600107A RID: 4218 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000269")]
		public SpellList SpecialSpellsList
		{
			[Token(Token = "0x600107A")]
			[Address(RVA = "0x6277", Offset = "0x6277", VA = "0x6277")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700026A RID: 618
		// (get) Token: 0x0600107B RID: 4219 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700026A")]
		public BasicSpellInfo BasicSpellInfo
		{
			[Token(Token = "0x600107B")]
			[Address(RVA = "0x6278", Offset = "0x6278", VA = "0x6278")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700026B RID: 619
		// (get) Token: 0x0600107C RID: 4220 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700026B")]
		public SpellUpgradeInfo SpellUpgradeInfo
		{
			[Token(Token = "0x600107C")]
			[Address(RVA = "0x6279", Offset = "0x6279", VA = "0x6279")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700026C RID: 620
		// (get) Token: 0x0600107D RID: 4221 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700026C")]
		public Button SpellInfoButton
		{
			[Token(Token = "0x600107D")]
			[Address(RVA = "0x627A", Offset = "0x627A", VA = "0x627A")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600107E RID: 4222 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600107E")]
		[Address(RVA = "0x627B", Offset = "0x627B", VA = "0x627B", Slot = "22")]
		protected override void OnShow(SchoolWindowArgs args)
		{
		/* --- GHIDRA: OnShow ---
		void UI_Windows_Buildings_MageSchoolWindow_SchoolWindow2__OnShow(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  undefined4 uVar4;
		  int *piVar5;
		  longlong lVar6;
		  undefined4 uVar7;
		  longlong lVar8;
		  uint uVar9;
		  
		  if (DAT_ram_00a58ace == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Isles_Base_AbstractIsle_UserIsleEvents__UserIsleModel__UserIsleController__UserBuildingTypes__get_Id__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Isles_Base_AbstractIsle_UserIsleEvents__UserIsleModel__UserIsleController__UserBuildingTypes__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Method_UI_Windows_BaseWindow_SchoolWindowArgs__get_WindowArgs__);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_School_Controller_SchoolController_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_MageSchool_Events_SchoolEvents_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_School_Model_SchoolModel_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_School_Controller_SchoolViewMediator2_TypeInfo);
		    DAT_ram_00a58ace = '\x01';
		  }
		  if (*(char *)(param1 + 0x58) == '\0') {
		    iVar1 = func_ii_8093(param1,Method_UI_Windows_BaseWindow_SchoolWindowArgs__get_WindowArgs__);
		    lVar8 = *(longlong *)(*(int *)(iVar1 + 0x18) + 0x18);
		    iVar1 = func_ii_8093(param1,Method_UI_Windows_BaseWindow_SchoolWindowArgs__get_WindowArgs__);
		    lVar6 = System_Collections_Generic_LinkedList_Enumerator_object___MoveNext
		                      (*(undefined4 *)(iVar1 + 0x20),0);
		    if (lVar8 == lVar6) {
		      if (DAT_ram_00a6456f == '\0') {
		        Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		        DAT_ram_00a6456f = '\x01';
		      }
		      uVar9 = 0;
		      piVar5 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		      iVar1 = *piVar5;
		      if (*(ushort *)(iVar1 + 0xb6) != 0) {
		        do {
		          if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar1 + 0x58) + uVar9 * 8)) {
		            puVar2 = (uint *)(*(int *)(*(int *)(iVar1 + 0x58) + uVar9 * 8 + 4) * 8 + iVar1 + 0x128);
		            goto code_r0x80f72058;
		          }
		          uVar9 = uVar9 + 1;
		        } while (*(ushort *)(iVar1 + 0xb6) != uVar9);
		      }
		      puVar2 = (uint *)func_ii_1080(piVar5,Core_Gameplay_IGame_TypeInfo,0xd);
		code_r0x80f72058:
		      iVar1 = (**(code **)((ulonglong)*puVar2 * 4))(piVar5,puVar2[1]);
		      *(undefined4 *)(param1 + 0x5c) = *(undefined4 *)(iVar1 + 0x10);
		      if (DAT_ram_00a6456f == '\0') {
		        Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		        DAT_ram_00a6456f = '\x01';
		      }
		      piVar5 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		      iVar1 = *piVar5;
		      if (*(ushort *)(iVar1 + 0xb6) != 0) {
		        uVar9 = 0;
		        do {
		          if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar1 + 0x58) + uVar9 * 8)) {
		            puVar2 = (uint *)(*(int *)(*(int *)(iVar1 + 0x58) + uVar9 * 8 + 4) * 8 + iVar1 + 0x128);
		            goto code_r0x80f7210a;
		          }
		          uVar9 = uVar9 + 1;
		        } while (*(ushort *)(iVar1 + 0xb6) != uVar9);
		      }
		      puVar2 = (uint *)func_ii_1080(piVar5,Core_Gameplay_IGame_TypeInfo,0xd);
		code_r0x80f7210a:
		      iVar1 = (**(code **)((ulonglong)*puVar2 * 4))(piVar5,puVar2[1]);
		      *(undefined4 *)(param1 + 0x60) = *(undefined4 *)(iVar1 + 0x14);
		      if (DAT_ram_00a6456f == '\0') {
		        Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		        DAT_ram_00a6456f = '\x01';
		      }
		      piVar5 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		      iVar1 = *piVar5;
		      if (*(ushort *)(iVar1 + 0xb6) != 0) {
		        uVar9 = 0;
		        do {
		          if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar1 + 0x58) + uVar9 * 8)) {
		            puVar2 = (uint *)(*(int *)(*(int *)(iVar1 + 0x58) + uVar9 * 8 + 4) * 8 + iVar1 + 0x128);
		            goto code_r0x80f721bc;
		          }
		          uVar9 = uVar9 + 1;
		        } while (*(ushort *)(iVar1 + 0xb6) != uVar9);
		      }
		      puVar2 = (uint *)func_ii_1080(piVar5,Core_Gameplay_IGame_TypeInfo,0xd);
		code_r0x80f721bc:
		      iVar1 = (**(code **)((ulonglong)*puVar2 * 4))(piVar5,puVar2[1]);
		      uVar3 = *(undefined4 *)(iVar1 + 0x18);
		    }
		    else {
		      uVar3 = unnamed_function_1417(Gameplay_MageSchool_Events_SchoolEvents_TypeInfo);
		      *(undefined4 *)(param1 + 0x5c) = uVar3;
		      iVar1 = func_ii_8093(param1,Method_UI_Windows_BaseWindow_SchoolWindowArgs__get_WindowArgs__);
		      uVar3 = *(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x18) + 0x10) + 8);
		      iVar1 = func_ii_8093(param1,Method_UI_Windows_BaseWindow_SchoolWindowArgs__get_WindowArgs__);
		      uVar7 = *(undefined4 *)(iVar1 + 0x20);
		      uVar4 = unnamed_function_1417(Gameplay_School_Model_SchoolModel_TypeInfo);
		      Gameplay_School_Model_SchoolModel__get_Dict(uVar4,uVar3,uVar7,0);
		      *(undefined4 *)(param1 + 0x60) = uVar4;
		      uVar7 = *(undefined4 *)(param1 + 0x5c);
		      uVar3 = unnamed_function_1417(Gameplay_School_Controller_SchoolController_TypeInfo);
		      Gameplay_School_Controller_SchoolController__Dispose(uVar3,uVar4,uVar7,0);
		    }
		    *(undefined4 *)(param1 + 100) = uVar3;
		    uVar4 = *(undefined4 *)(param1 + 0x60);
		    uVar7 = *(undefined4 *)(param1 + 0x5c);
		    piVar5 = (int *)unnamed_function_1417(Gameplay_School_Controller_SchoolViewMediator2_TypeInfo);
		    Gameplay_School_Controller_SchoolViewMediator2__set_View(piVar5,uVar4,uVar7,uVar3,0);
		    *(int **)(param1 + 0x68) = piVar5;
		    (**(code **)((ulonglong)*(uint *)(*piVar5 + 0x160) * 4))
		              (piVar5,param1,*(undefined4 *)(*piVar5 + 0x164));
		    MVC_AbstractController__Dispose(*(undefined4 *)(param1 + 100),0);
		    *(undefined1 *)(param1 + 0x58) = 1;
		  }
		  return;
		}
		*/

		}

		// Token: 0x0600107F RID: 4223 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600107F")]
		[Address(RVA = "0x627C", Offset = "0x627C", VA = "0x627C")]
		private void SetupMvc()
		{
		/* --- GHIDRA: SetupMvc ---
		void UI_Windows_Buildings_MageSchoolWindow_SchoolWindow2__SetupMvc(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  longlong lVar2;
		  longlong lVar3;
		  
		  if (DAT_ram_00a58acf == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Isles_Base_AbstractIsle_UserIsleEvents__UserIsleModel__UserIsleController__UserBuildingTypes__get_Id__
		              );
		    Mono_Security_ASN1__get_Item(&Method_UI_Windows_BaseWindow_SchoolWindowArgs__get_WindowArgs__);
		    DAT_ram_00a58acf = '\x01';
		  }
		  if (*(char *)(param1 + 0x58) != '\0') {
		    iVar1 = func_ii_8093(param1,Method_UI_Windows_BaseWindow_SchoolWindowArgs__get_WindowArgs__);
		    lVar3 = *(longlong *)(*(int *)(iVar1 + 0x18) + 0x18);
		    iVar1 = func_ii_8093(param1,Method_UI_Windows_BaseWindow_SchoolWindowArgs__get_WindowArgs__);
		    lVar2 = System_Collections_Generic_LinkedList_Enumerator_object___MoveNext
		                      (*(undefined4 *)(iVar1 + 0x20),0);
		    if (lVar3 != lVar2) {
		      MVC_AbstractController__Run(*(undefined4 *)(param1 + 100),0);
		      iVar1 = **(int **)(param1 + 100);
		      (**(code **)((ulonglong)*(uint *)(iVar1 + 0xe8) * 4))
		                (*(int **)(param1 + 100),*(undefined4 *)(iVar1 + 0xec));
		      iVar1 = **(int **)(param1 + 0x60);
		      (**(code **)((ulonglong)*(uint *)(iVar1 + 0xe8) * 4))
		                (*(int **)(param1 + 0x60),*(undefined4 *)(iVar1 + 0xec));
		    }
		    iVar1 = **(int **)(param1 + 0x68);
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0x130) * 4))
		              (*(int **)(param1 + 0x68),*(undefined4 *)(iVar1 + 0x134));
		    *(undefined8 *)(param1 + 0x60) = 0;
		    iVar1 = **(int **)(param1 + 0x68);
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0x160) * 4))
		              (*(int **)(param1 + 0x68),0,*(undefined4 *)(iVar1 + 0x164));
		    iVar1 = **(int **)(param1 + 0x68);
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0x140) * 4))
		              (*(int **)(param1 + 0x68),0,*(undefined4 *)(iVar1 + 0x144));
		    *(undefined4 *)(param1 + 0x5c) = 0;
		    *(undefined4 *)(param1 + 0x68) = 0;
		  }
		  return;
		}
		*/

		}

		// Token: 0x06001080 RID: 4224 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001080")]
		[Address(RVA = "0x627D", Offset = "0x627D", VA = "0x627D")]
		private void DestroyMvc()
		{
		/* --- GHIDRA: DestroyMvc ---
		void UI_Windows_Buildings_MageSchoolWindow_SchoolWindow2__DestroyMvc
		               (int param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a58ad0 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Elements_GenericList_SelectorGenericList_SpellListArgs__SpellItem__SpellItemArgs__SelectByIndex__
		              );
		    DAT_ram_00a58ad0 = '\x01';
		  }
		  UI_Elements_GenericList_SelectorGenericList_object__object__object___SelectByIndex
		            (*(undefined4 *)(param1 + 0x40),0xffffffff,1,
		             Method_UI_Elements_GenericList_SelectorGenericList_SpellListArgs__SpellItem__SpellItemArgs__SelectByIndex__
		            );
		  iVar1 = *(int *)(param1 + 0x50);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(param2 + 0xc),
		               *(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06001081 RID: 4225 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001081")]
		[Address(RVA = "0x627E", Offset = "0x627E", VA = "0x627E")]
		private void OnNeutralSpellClick(SpellItemArgs spellItemArgs)
		{
		/* --- GHIDRA: OnNeutralSpellClick ---
		void UI_Windows_Buildings_MageSchoolWindow_SchoolWindow2__OnNeutralSpellClick
		               (int param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a58ad1 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Elements_GenericList_SelectorGenericList_SpellListArgs__SpellItem__SpellItemArgs__SelectByIndex__
		              );
		    DAT_ram_00a58ad1 = '\x01';
		  }
		  UI_Elements_GenericList_SelectorGenericList_object__object__object___SelectByIndex
		            (*(undefined4 *)(param1 + 0x3c),0xffffffff,1,
		             Method_UI_Elements_GenericList_SelectorGenericList_SpellListArgs__SpellItem__SpellItemArgs__SelectByIndex__
		            );
		  iVar1 = *(int *)(param1 + 0x50);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(param2 + 0xc),
		               *(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06001082 RID: 4226 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001082")]
		[Address(RVA = "0x627F", Offset = "0x627F", VA = "0x627F")]
		private void OnSpecialSpellClick(SpellItemArgs spellItemArgs)
		{
		/* --- GHIDRA: OnSpecialSpellClick ---
		void UI_Windows_Buildings_MageSchoolWindow_SchoolWindow2__OnSpecialSpellClick
		               (int param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  iVar1 = *(int *)(param1 + 0x54);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(param2 + 0xc),
		               *(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06001083 RID: 4227 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001083")]
		[Address(RVA = "0x6280", Offset = "0x6280", VA = "0x6280")]
		private void OnDeselectSpellClick(SpellItemArgs spellItemArgs)
		{
		/* --- GHIDRA: OnDeselectSpellClick ---
		void UI_Windows_Buildings_MageSchoolWindow_SchoolWindow2__OnDeselectSpellClick
		               (undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a58ad2 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UI_Windows_ClosableBaseWindow_SchoolWindowArgs__OnClose__);
		    DAT_ram_00a58ad2 = '\x01';
		  }
		  UI_Windows_Buildings_MageSchoolWindow_SchoolWindow2__SetupMvc(param1,param1);
		  UI_Windows_ClosableBaseWindow_object___OnClickBack
		            (param1,Method_UI_Windows_ClosableBaseWindow_SchoolWindowArgs__OnClose__);
		  return;
		}
		*/

		}

		// Token: 0x06001084 RID: 4228 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001084")]
		[Address(RVA = "0x6281", Offset = "0x6281", VA = "0x6281", Slot = "19")]
		protected override void OnClose()
		{
		/* --- GHIDRA: OnClose ---
		void UI_Windows_Buildings_MageSchoolWindow_SchoolWindow2__OnClose
		               (undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a58ad3 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UI_Windows_ClosableBaseWindow_SchoolWindowArgs___ctor__);
		    DAT_ram_00a58ad3 = '\x01';
		  }
		  UI_MonoBehaviourWithStates_ClientStateChangedDelegate___Il2CppFullySharedGenericStructType___Invoke
		            (param1,Method_UI_Windows_ClosableBaseWindow_SchoolWindowArgs___ctor__);
		  return;
		}
		*/

		}

		// Token: 0x06001085 RID: 4229 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001085")]
		[Address(RVA = "0x6282", Offset = "0x6282", VA = "0x6282")]
		public SchoolWindow2()
		{
		}

		// Token: 0x04000874 RID: 2164
		[Token(Token = "0x4000874")]
		public const string WINDOW_ID = "Prefabs/UI/Windows/MageSchool/MageSchoolWindow2";

		// Token: 0x04000875 RID: 2165
		[Token(Token = "0x4000875")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private SpellList _neutralSpellList;

		// Token: 0x04000876 RID: 2166
		[Token(Token = "0x4000876")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private SpellList _specialSpellList;

		// Token: 0x04000877 RID: 2167
		[Token(Token = "0x4000877")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private BasicSpellInfo _basicSpellInfo;

		// Token: 0x04000878 RID: 2168
		[Token(Token = "0x4000878")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private SpellUpgradeInfo _spellUpgradeInfo;

		// Token: 0x04000879 RID: 2169
		[Token(Token = "0x4000879")]
		[FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private Button _spellInfoButton;

		// Token: 0x0400087C RID: 2172
		[Token(Token = "0x400087C")]
		[FieldOffset(Offset = "0x58")]
		private bool _isMvcInitialized;

		// Token: 0x0400087D RID: 2173
		[Token(Token = "0x400087D")]
		[FieldOffset(Offset = "0x5C")]
		private SchoolEvents _events;

		// Token: 0x0400087E RID: 2174
		[Token(Token = "0x400087E")]
		[FieldOffset(Offset = "0x60")]
		private SchoolModel _model;

		// Token: 0x0400087F RID: 2175
		[Token(Token = "0x400087F")]
		[FieldOffset(Offset = "0x64")]
		private SchoolController _controller;

		// Token: 0x04000880 RID: 2176
		[Token(Token = "0x4000880")]
		[FieldOffset(Offset = "0x68")]
		private SchoolViewMediator2 _mediator;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_WindowId ---
		void UI_Windows_Buildings_MageSchoolWindow_SchoolWindow2__get_WindowId
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a58ac9 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_uint__TypeInfo);
		    DAT_ram_00a58ac9 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x50);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_uint__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_uint__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0x50,iVar2,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,param2_00);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/


		/* --- GHIDRA: add_OnSelectSpell ---
		void UI_Windows_Buildings_MageSchoolWindow_SchoolWindow2__add_OnSelectSpell
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a58aca == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_uint__TypeInfo);
		    DAT_ram_00a58aca = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x50);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_uint__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_uint__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0x50,iVar2,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,param2_00);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/


		/* --- GHIDRA: remove_OnSelectSpell ---
		void UI_Windows_Buildings_MageSchoolWindow_SchoolWindow2__remove_OnSelectSpell
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a58acb == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_uint__TypeInfo);
		    DAT_ram_00a58acb = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x54);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_uint__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_uint__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0x54,iVar2,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,param2_00);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/


		/* --- GHIDRA: add_OnDeselectSpell ---
		void UI_Windows_Buildings_MageSchoolWindow_SchoolWindow2__add_OnDeselectSpell
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a58acc == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_uint__TypeInfo);
		    DAT_ram_00a58acc = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x54);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_uint__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_uint__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0x54,iVar2,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,param2_00);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/


		/* --- GHIDRA: get_SpellInfoButton ---
		void UI_Windows_Buildings_MageSchoolWindow_SchoolWindow2__get_SpellInfoButton
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a58acd == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UI_Windows_ClosableBaseWindow_SchoolWindowArgs__OnShow__);
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Windows_Buildings_MageSchoolWindow_SchoolWindow2_OnDeselectSpellClick__);
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Windows_Buildings_MageSchoolWindow_SchoolWindow2_OnNeutralSpellClick__);
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Windows_Buildings_MageSchoolWindow_SchoolWindow2_OnSpecialSpellClick__);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_SpellItemArgs__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Events_UnityEvent_SpellItemArgs__AddListener__)
		    ;
		    DAT_ram_00a58acd = '\x01';
		  }
		  func_ii_7769(param1,param2,Method_UI_Windows_ClosableBaseWindow_SchoolWindowArgs__OnShow__);
		  uVar2 = *(undefined4 *)(*(int *)(param1 + 0x3c) + 0x18);
		  uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_SpellItemArgs__TypeInfo);
		  func_ii_7054(uVar1,param1,
		               Method_UI_Windows_Buildings_MageSchoolWindow_SchoolWindow2_OnNeutralSpellClick__,0);
		  UnityEngine_Events_UnityEvent_InputAction_CallbackContext____ctor
		            (uVar2,uVar1,Method_UnityEngine_Events_UnityEvent_SpellItemArgs__AddListener__);
		  uVar2 = *(undefined4 *)(*(int *)(param1 + 0x40) + 0x18);
		  uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_SpellItemArgs__TypeInfo);
		  func_ii_7054(uVar1,param1,
		               Method_UI_Windows_Buildings_MageSchoolWindow_SchoolWindow2_OnSpecialSpellClick__,0);
		  UnityEngine_Events_UnityEvent_InputAction_CallbackContext____ctor
		            (uVar2,uVar1,Method_UnityEngine_Events_UnityEvent_SpellItemArgs__AddListener__);
		  uVar2 = *(undefined4 *)(*(int *)(param1 + 0x3c) + 0x24);
		  uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_SpellItemArgs__TypeInfo);
		  func_ii_7054(uVar1,param1,
		               Method_UI_Windows_Buildings_MageSchoolWindow_SchoolWindow2_OnDeselectSpellClick__,0);
		  UnityEngine_Events_UnityEvent_InputAction_CallbackContext____ctor
		            (uVar2,uVar1,Method_UnityEngine_Events_UnityEvent_SpellItemArgs__AddListener__);
		  uVar2 = *(undefined4 *)(*(int *)(param1 + 0x40) + 0x24);
		  uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_SpellItemArgs__TypeInfo);
		  func_ii_7054(uVar1,param1,
		               Method_UI_Windows_Buildings_MageSchoolWindow_SchoolWindow2_OnDeselectSpellClick__,0);
		  UnityEngine_Events_UnityEvent_InputAction_CallbackContext____ctor
		            (uVar2,uVar1,Method_UnityEngine_Events_UnityEvent_SpellItemArgs__AddListener__);
		  UI_Windows_Buildings_MageSchoolWindow_SchoolWindow2__OnShow(param1,param1);
		  return;
		}
		*/

}
