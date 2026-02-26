using System;
using System.Collections.Generic;
using Gameplay.Clans.Office.Events;
using Gameplay.Clans.Office.Model;
using Gameplay.Clans.Office.View;
using Il2CppDummyDll;
using MVC;
using MVC.Interfaces;

namespace Gameplay.Clans.Office.Controller
{
	// Token: 0x02000A6C RID: 2668
	[Token(Token = "0x2000A6C")]
	public class ClanOfficeViewMediator : AbstractViewMediator<ClanOfficeModel, ClanOfficeEvents, ClanOfficeController, ClanOfficeWindow>
	{
		// Token: 0x06003F4E RID: 16206 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F4E")]
		[Address(RVA = "0x8E09", Offset = "0x8E09", VA = "0x8E09")]
		public ClanOfficeViewMediator(ClanOfficeModel model, ClanOfficeEvents events, ClanOfficeController controller)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Clans_Office_Controller_ClanOfficeViewMediator___ctor
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  undefined4 uVar3;
		  
		  if (DAT_ram_00a5765c == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ClanOfficeModel__ClanOfficeEvents__ClanOfficeController__ClanOfficeWindow__set_View__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Office_Controller_ClanOfficeViewMediator_TabChangedEventHandler__
		              );
		    DAT_ram_00a5765c = '\x01';
		  }
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar1,0);
		  if (iVar2 != 0) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(iVar2 + 0x3c);
		    uVar1 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar1,param1,
		               Method_Gameplay_Clans_Office_Controller_ClanOfficeViewMediator_TabChangedEventHandler__
		               ,0);
		    UI_Tabs_TabBar__add_ChangeEvent(uVar3,uVar1,0);
		  }
		  param1[5] = param2;
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar1,0);
		  if (iVar2 != 0) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(iVar2 + 0x3c);
		    uVar1 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar1,param1,
		               Method_Gameplay_Clans_Office_Controller_ClanOfficeViewMediator_TabChangedEventHandler__
		               ,0);
		    UI_Tabs_CategoryTabBarItemView___ctor(uVar3,uVar1,0);
		    Gameplay_Clans_Office_Controller_ClanOfficeViewMediator__set_View(param1,param1);
		  }
		  return;
		}
		*/

		}

		// Token: 0x17000C9E RID: 3230
		// (set) Token: 0x06003F4F RID: 16207 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C9E")]
		public override ClanOfficeWindow View
		{
			[Token(Token = "0x6003F4F")]
			[Address(RVA = "0x8E0A", Offset = "0x8E0A", VA = "0x8E0A", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x06003F50 RID: 16208 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F50")]
		[Address(RVA = "0x8E0B", Offset = "0x8E0B", VA = "0x8E0B")]
		private void Init()
		{
		/* --- GHIDRA: Init ---
		void Gameplay_Clans_Office_Controller_ClanOfficeViewMediator__Init(int *param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  int *param1_00;
		  int iVar3;
		  int param1_01;
		  
		  if (DAT_ram_00a5765e == '\0') {
		    Mono_Security_ASN1__get_Item(&MVC_Interfaces_IHideableMediator_TypeInfo);
		    DAT_ram_00a5765e = '\x01';
		  }
		  param1_00 = (int *)param1[10];
		  iVar3 = *param1_00;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (MVC_Interfaces_IHideableMediator_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8))
		      {
		        puVar2 = (uint *)(iVar3 + *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x80dbf62f;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,MVC_Interfaces_IHideableMediator_TypeInfo,0);
		code_r0x80dbf62f:
		  (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		  if (DAT_ram_00a57660 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_uint__Func_IHideableMediator___get_Item__
		              );
		    DAT_ram_00a57660 = '\x01';
		  }
		  param1_01 = param1[9];
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar3 = UI_Tabs_TabBar__get_SelectedIndex(*(undefined4 *)(iVar3 + 0x3c),0);
		  iVar3 = System_Collections_Generic_List_object___get_Item
		                    (param1_01,*(undefined4 *)(iVar3 + 0x14),
		                     Method_System_Collections_Generic_Dictionary_uint__Func_IHideableMediator___get_Item__
		                    );
		  iVar3 = (**(code **)((ulonglong)*(uint *)(iVar3 + 0xc) * 4))
		                    (*(undefined4 *)(iVar3 + 0x20),*(undefined4 *)(iVar3 + 0x14));
		  param1[10] = iVar3;
		  return;
		}
		*/

		}

		// Token: 0x06003F51 RID: 16209 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F51")]
		[Address(RVA = "0x8E0C", Offset = "0x8E0C", VA = "0x8E0C")]
		private void TabChangedEventHandler()
		{
		/* --- GHIDRA: TabChangedEventHandler ---
		void Gameplay_Clans_Office_Controller_ClanOfficeViewMediator__TabChangedEventHandler
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  int iVar2;
		  undefined4 uVar3;
		  int *piVar4;
		  undefined4 uVar5;
		  
		  if (DAT_ram_00a5765f == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ClanOfficeModel__ClanOfficeEvents__ClanOfficeController__ClanOfficeWindow__set_Events__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Office_Controller_ClanOfficeViewMediator_RequestCloseOfficeWindowEventHandler__
		              );
		    DAT_ram_00a5765f = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x13c));
		  if (iVar1 != 0) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar5 = *(undefined4 *)(iVar2 + 0x24);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_Clans_Office_Controller_ClanOfficeViewMediator_RequestCloseOfficeWindowEventHandler__
		               ,0);
		    piVar4 = (int *)func_ii_7048(uVar5,uVar3,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar4 == (int *)0x0) {
		      *(undefined4 *)(iVar2 + 0x24) = 0;
		    }
		    else if ((System_Action_TypeInfo != *piVar4) ||
		            (*(int **)(iVar2 + 0x24) = piVar4, *piVar4 != iVar1)) {
		      System_Activator__CreateInstance(piVar4,iVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  param1[3] = param2;
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x13c));
		  if (iVar1 != 0) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar5 = *(undefined4 *)(iVar2 + 0x24);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_Clans_Office_Controller_ClanOfficeViewMediator_RequestCloseOfficeWindowEventHandler__
		               ,0);
		    piVar4 = (int *)UnityEngine_UI_Image__set_sprite(uVar5,uVar3,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar4 == (int *)0x0) {
		      *(undefined4 *)(iVar2 + 0x24) = 0;
		      return;
		    }
		    if ((System_Action_TypeInfo != *piVar4) || (*(int **)(iVar2 + 0x24) = piVar4, *piVar4 != iVar1))
		    {
		      System_Activator__CreateInstance(piVar4,iVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x17000C9F RID: 3231
		// (set) Token: 0x06003F52 RID: 16210 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C9F")]
		public override ClanOfficeEvents Events
		{
			[Token(Token = "0x6003F52")]
			[Address(RVA = "0x8E0D", Offset = "0x8E0D", VA = "0x8E0D", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x06003F53 RID: 16211 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F53")]
		[Address(RVA = "0x8E0E", Offset = "0x8E0E", VA = "0x8E0E")]
		private void RequestCloseOfficeWindowEventHandler()
		{
		/* --- GHIDRA: RequestCloseOfficeWindowEventHandler ---
		void Gameplay_Clans_Office_Controller_ClanOfficeViewMediator__RequestCloseOfficeWindowEventHandler
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  int param1_00;
		  
		  if (DAT_ram_00a57660 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_uint__Func_IHideableMediator___get_Item__
		              );
		    DAT_ram_00a57660 = '\x01';
		  }
		  param1_00 = param1[9];
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar1 = UI_Tabs_TabBar__get_SelectedIndex(*(undefined4 *)(iVar1 + 0x3c),0);
		  iVar1 = System_Collections_Generic_List_object___get_Item
		                    (param1_00,*(undefined4 *)(iVar1 + 0x14),
		                     Method_System_Collections_Generic_Dictionary_uint__Func_IHideableMediator___get_Item__
		                    );
		  iVar1 = (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		                    (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(iVar1 + 0x14));
		  param1[10] = iVar1;
		  return;
		}
		*/

		}

		// Token: 0x06003F54 RID: 16212 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F54")]
		[Address(RVA = "0x8E0F", Offset = "0x8E0F", VA = "0x8E0F")]
		private void AssignNewMediator()
		{
		/* --- GHIDRA: AssignNewMediator ---
		int Gameplay_Clans_Office_Controller_ClanOfficeViewMediator__AssignNewMediator
		              (int *param1,undefined4 param2)
		
		{
		  undefined4 param4;
		  undefined4 uVar1;
		  int iVar2;
		  int *piVar3;
		  int iVar4;
		  
		  if (DAT_ram_00a57661 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Clans_Office_Controller_AboutClansViewMediator_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ClanOfficeModel__ClanOfficeEvents__ClanOfficeController__ClanOfficeWindow__get_Model__
		              );
		    DAT_ram_00a57661 = '\x01';
		  }
		  piVar3 = (int *)param1[8];
		  if (piVar3 == (int *)0x0) {
		    iVar2 = param1[2];
		    uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    param4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                       (param1,*(undefined4 *)(*param1 + 0x14c));
		    piVar3 = (int *)unnamed_function_1417
		                              (Gameplay_Clans_Office_Controller_AboutClansViewMediator_TypeInfo);
		    Gameplay_Clans_Office_Events_ClanWars_ClanWarsHistoryEvents___ctor(piVar3,iVar2,uVar1,param4,0);
		    param1[8] = (int)piVar3;
		  }
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x13c));
		  (**(code **)((ulonglong)*(uint *)(*piVar3 + 0x140) * 4))
		            (piVar3,uVar1,*(undefined4 *)(*piVar3 + 0x144));
		  piVar3 = (int *)param1[8];
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar4 = *piVar3;
		  (**(code **)((ulonglong)*(uint *)(iVar4 + 0x160) * 4))
		            (piVar3,*(undefined4 *)(iVar2 + 0x48),*(undefined4 *)(iVar4 + 0x164));
		  return param1[8];
		}
		*/

		}

		// Token: 0x06003F55 RID: 16213 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003F55")]
		[Address(RVA = "0x8E10", Offset = "0x8E10", VA = "0x8E10")]
		private IHideableMediator ShowAboutClansTab()
		{
		/* --- GHIDRA: ShowAboutClansTab ---
		int Gameplay_Clans_Office_Controller_ClanOfficeViewMediator__ShowAboutClansTab
		              (int *param1,undefined4 param2)
		
		{
		  undefined4 param4;
		  undefined4 uVar1;
		  int iVar2;
		  int *piVar3;
		  int iVar4;
		  
		  if (DAT_ram_00a57662 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ClanOfficeModel__ClanOfficeEvents__ClanOfficeController__ClanOfficeWindow__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Clans_Office_Controller_ClanCreationViewMediator_TypeInfo);
		    DAT_ram_00a57662 = '\x01';
		  }
		  piVar3 = (int *)param1[6];
		  if (piVar3 == (int *)0x0) {
		    iVar2 = param1[2];
		    uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    param4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                       (param1,*(undefined4 *)(*param1 + 0x14c));
		    piVar3 = (int *)unnamed_function_1417
		                              (Gameplay_Clans_Office_Controller_ClanCreationViewMediator_TypeInfo);
		    Gameplay_Clans_Office_Controller_AboutClansViewMediator__Hide(piVar3,iVar2,uVar1,param4,0);
		    param1[6] = (int)piVar3;
		  }
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x13c));
		  (**(code **)((ulonglong)*(uint *)(*piVar3 + 0x140) * 4))
		            (piVar3,uVar1,*(undefined4 *)(*piVar3 + 0x144));
		  piVar3 = (int *)param1[6];
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar4 = *piVar3;
		  (**(code **)((ulonglong)*(uint *)(iVar4 + 0x160) * 4))
		            (piVar3,*(undefined4 *)(iVar2 + 0x40),*(undefined4 *)(iVar4 + 0x164));
		  return param1[6];
		}
		*/

			return null;
		}

		// Token: 0x06003F56 RID: 16214 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003F56")]
		[Address(RVA = "0x8E11", Offset = "0x8E11", VA = "0x8E11")]
		private IHideableMediator ShowClanCreationTab()
		{
		/* --- GHIDRA: ShowClanCreationTab ---
		int Gameplay_Clans_Office_Controller_ClanOfficeViewMediator__ShowClanCreationTab
		              (int *param1,undefined4 param2)
		
		{
		  undefined4 param4;
		  undefined4 uVar1;
		  int iVar2;
		  int *piVar3;
		  int iVar4;
		  
		  if (DAT_ram_00a57663 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ClanOfficeModel__ClanOfficeEvents__ClanOfficeController__ClanOfficeWindow__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Gameplay_Clans_Office_Controller_VacanciesViewMediator_TypeInfo);
		    DAT_ram_00a57663 = '\x01';
		  }
		  piVar3 = (int *)param1[7];
		  if (piVar3 == (int *)0x0) {
		    iVar2 = param1[2];
		    uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    param4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                       (param1,*(undefined4 *)(*param1 + 0x14c));
		    piVar3 = (int *)unnamed_function_1417
		                              (Gameplay_Clans_Office_Controller_VacanciesViewMediator_TypeInfo);
		    if (DAT_ram_00a576d3 == '\0') {
		      Mono_Security_ASN1__get_Item
		                (&
		                 Method_MVC_AbstractViewMediator_ClanOfficeModel__ClanOfficeEvents__ClanOfficeController__VacanciesView___ctor__
		                );
		      DAT_ram_00a576d3 = '\x01';
		    }
		    Gameplay_Combat_TeamCombat_View_AbstractTeamCombatView_object___get_HideInstantElements
		              (piVar3,iVar2,uVar1,param4,
		               Method_MVC_AbstractViewMediator_ClanOfficeModel__ClanOfficeEvents__ClanOfficeController__VacanciesView___ctor__
		              );
		    param1[7] = (int)piVar3;
		  }
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x13c));
		  (**(code **)((ulonglong)*(uint *)(*piVar3 + 0x140) * 4))
		            (piVar3,uVar1,*(undefined4 *)(*piVar3 + 0x144));
		  piVar3 = (int *)param1[7];
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar4 = *piVar3;
		  (**(code **)((ulonglong)*(uint *)(iVar4 + 0x160) * 4))
		            (piVar3,*(undefined4 *)(iVar2 + 0x44),*(undefined4 *)(iVar4 + 0x164));
		  return param1[7];
		}
		*/

			return null;
		}

		// Token: 0x06003F57 RID: 16215 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003F57")]
		[Address(RVA = "0x8E12", Offset = "0x8E12", VA = "0x8E12")]
		private IHideableMediator ShowVacanciesTab()
		{
		/* --- GHIDRA: ShowVacanciesTab ---
		void Gameplay_Clans_Office_Controller_ClanOfficeViewMediator__ShowVacanciesTab
		               (int param1,undefined4 param2)
		
		{
		  int *piVar1;
		  
		  if (DAT_ram_00a57664 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ClanOfficeModel__ClanOfficeEvents__ClanOfficeController__ClanOfficeWindow__Dispose__
		              );
		    DAT_ram_00a57664 = '\x01';
		  }
		  piVar1 = *(int **)(param1 + 0x20);
		  if (piVar1 != (int *)0x0) {
		    (**(code **)((ulonglong)*(uint *)(*piVar1 + 0x130) * 4))
		              (piVar1,*(undefined4 *)(*piVar1 + 0x134));
		  }
		  piVar1 = *(int **)(param1 + 0x18);
		  if (piVar1 != (int *)0x0) {
		    (**(code **)((ulonglong)*(uint *)(*piVar1 + 0x130) * 4))
		              (piVar1,*(undefined4 *)(*piVar1 + 0x134));
		  }
		  piVar1 = *(int **)(param1 + 0x1c);
		  if (piVar1 != (int *)0x0) {
		    (**(code **)((ulonglong)*(uint *)(*piVar1 + 0x130) * 4))
		              (piVar1,*(undefined4 *)(*piVar1 + 0x134));
		  }
		  MVC_AbstractViewMediator_object__object__object__object___Core_MVC_Interfaces_IViewMediator_set_View
		            (param1,
		             Method_MVC_AbstractViewMediator_ClanOfficeModel__ClanOfficeEvents__ClanOfficeController__ClanOfficeWindow__Dispose__
		            );
		  return;
		}
		*/

			return null;
		}

		// Token: 0x06003F58 RID: 16216 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F58")]
		[Address(RVA = "0x8E13", Offset = "0x8E13", VA = "0x8E13", Slot = "14")]
		public override void Dispose()
		{
		/* --- GHIDRA: Dispose ---
		void Gameplay_Clans_Office_Controller_ClanOfficeViewMediator__Dispose
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4,undefined4 param5)
		
		{
		  undefined4 uVar1;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a57665 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ClanInfoModel__ClanInfoEvents__ClanInfoController__ClanOverview___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ClanInfoModel__ClanInfoEvents__ClanInfoController__ClanOverview__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&StringLiteral_21193);
		    Mono_Security_ASN1__get_Item(&StringLiteral_27843);
		    DAT_ram_00a57665 = '\x01';
		  }
		  Gameplay_Combat_TeamCombat_View_AbstractTeamCombatView_object___get_HideInstantElements
		            (param1,param2,param3,param4,
		             Method_MVC_AbstractViewMediator_ClanInfoModel__ClanInfoEvents__ClanInfoController__ClanOverview___ctor__
		            );
		  uVar1 = Gameplay_Clans_Office_View_AboutClansTab_AboutClansView___ctor
		                    (*(undefined4 *)(param1 + 8),0);
		  uVar1 = Core_Extensions_Dict_DictExt__GetBoolParameter(uVar1,StringLiteral_21193,0);
		  *(undefined4 *)(param1 + 0x18) = uVar1;
		  uVar1 = Gameplay_Clans_Office_View_AboutClansTab_AboutClansView___ctor
		                    (*(undefined4 *)(param1 + 8),0);
		  uVar1 = Core_Extensions_Dict_DictExt__GetBoolParameter(uVar1,StringLiteral_27843,0);
		  param1_00 = Protocol_Common_ResourceSet___ctor(*(undefined4 *)(param1 + 0x18),0);
		  uVar1 = Core_Extensions_Dict_RegularOptionDicExt__GetBankBgAssetId(param1_00,uVar1,0);
		  *(undefined4 *)(param1 + 0x1c) = uVar1;
		  return;
		}
		*/

		}

		// Token: 0x04002395 RID: 9109
		[Token(Token = "0x4002395")]
		[FieldOffset(Offset = "0x18")]
		private ClanCreationViewMediator _clanCreationViewMediator;

		// Token: 0x04002396 RID: 9110
		[Token(Token = "0x4002396")]
		[FieldOffset(Offset = "0x1C")]
		private VacanciesViewMediator _vacanciesViewMediator;

		// Token: 0x04002397 RID: 9111
		[Token(Token = "0x4002397")]
		[FieldOffset(Offset = "0x20")]
		private AboutClansViewMediator _aboutClansViewMediator;

		// Token: 0x04002398 RID: 9112
		[Token(Token = "0x4002398")]
		[FieldOffset(Offset = "0x24")]
		private Dictionary<uint, Func<IHideableMediator>> _tabsOpenersById;

		// Token: 0x04002399 RID: 9113
		[Token(Token = "0x4002399")]
		[FieldOffset(Offset = "0x28")]
		private IHideableMediator _currentMediator;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_View ---
		void Gameplay_Clans_Office_Controller_ClanOfficeViewMediator__set_View
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 param2_00;
		  undefined4 param1_00;
		  int param1_01;
		  
		  if (DAT_ram_00a5765d == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ClanOfficeModel__ClanOfficeEvents__ClanOfficeController__ClanOfficeWindow__get_Model__
		              );
		    DAT_ram_00a5765d = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  param1_00 = *(undefined4 *)(iVar1 + 0x3c);
		  param2_00 = Gameplay_Clans_Office_Model_ClanOfficeModel__set_RequestedClan(param1[2],0);
		  UI_Tabs_TabBar__HandleSelected(param1_00,param2_00,0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  Gameplay_GameEvents_Model_GameEventData__get_ContainsArtifactRewards
		            (*(undefined4 *)(iVar1 + 0x3c),0,1,0);
		  if (DAT_ram_00a57660 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_uint__Func_IHideableMediator___get_Item__
		              );
		    DAT_ram_00a57660 = '\x01';
		  }
		  param1_01 = param1[9];
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar1 = UI_Tabs_TabBar__get_SelectedIndex(*(undefined4 *)(iVar1 + 0x3c),0);
		  iVar1 = System_Collections_Generic_List_object___get_Item
		                    (param1_01,*(undefined4 *)(iVar1 + 0x14),
		                     Method_System_Collections_Generic_Dictionary_uint__Func_IHideableMediator___get_Item__
		                    );
		  iVar1 = (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		                    (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(iVar1 + 0x14));
		  param1[10] = iVar1;
		  return;
		}
		*/

}
