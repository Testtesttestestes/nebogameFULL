using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Gameplay.Clans.Buildings.MagicTower.Controller;
using Gameplay.Clans.Buildings.MagicTower.Events;
using Gameplay.Clans.Buildings.MagicTower.Model;
using Gameplay.Isles.Clan;
using Gameplay.School.Model;
using Gameplay.School.View;
using Il2CppDummyDll;
using UI.Windows.Buildings;
using UnityEngine;

namespace Gameplay.Clans.Buildings.MagicTower.View
{
	// Token: 0x02000AB3 RID: 2739
	[Token(Token = "0x2000AB3")]
	public class MagicTowerWindow : BaseClanBuildingWindow<MagicTowerWindow.MagicTowerWindowArgs>
	{
		// Token: 0x17000D04 RID: 3332
		// (get) Token: 0x06004212 RID: 16914 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000D04")]
		public override string WindowId
		{
			[Token(Token = "0x6004212")]
			[Address(RVA = "0x90C6", Offset = "0x90C6", VA = "0x90C6", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000D05 RID: 3333
		// (get) Token: 0x06004213 RID: 16915 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000D05")]
		public TitledListWithSpellTitle List
		{
			[Token(Token = "0x6004213")]
			[Address(RVA = "0x90C7", Offset = "0x90C7", VA = "0x90C7")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000D06 RID: 3334
		// (get) Token: 0x06004214 RID: 16916 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06004215 RID: 16917 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D06")]
		public ClanSpellListElement[] Spells
		{
			[Token(Token = "0x6004214")]
			[Address(RVA = "0x90C8", Offset = "0x90C8", VA = "0x90C8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004215")]
			[Address(RVA = "0x90C9", Offset = "0x90C9", VA = "0x90C9")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1400019F RID: 415
		// (add) Token: 0x06004216 RID: 16918 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06004217 RID: 16919 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400019F")]
		public event Action<SchoolSpellData> SelectSpellEvent
		{
			[Token(Token = "0x6004216")]
			[Address(RVA = "0x90CA", Offset = "0x90CA", VA = "0x90CA")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6004217")]
			[Address(RVA = "0x90CB", Offset = "0x90CB", VA = "0x90CB")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x140001A0 RID: 416
		// (add) Token: 0x06004218 RID: 16920 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06004219 RID: 16921 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140001A0")]
		public event Action DeselectSpellEvent
		{
			[Token(Token = "0x6004218")]
			[Address(RVA = "0x90CC", Offset = "0x90CC", VA = "0x90CC")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6004219")]
			[Address(RVA = "0x90CD", Offset = "0x90CD", VA = "0x90CD")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x140001A1 RID: 417
		// (add) Token: 0x0600421A RID: 16922 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600421B RID: 16923 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140001A1")]
		public event Action<SchoolSpellData> UseSpellButtonClickedEvent
		{
			[Token(Token = "0x600421A")]
			[Address(RVA = "0x90CE", Offset = "0x90CE", VA = "0x90CE")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600421B")]
			[Address(RVA = "0x90CF", Offset = "0x90CF", VA = "0x90CF")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x0600421C RID: 16924 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600421C")]
		[Address(RVA = "0x90D0", Offset = "0x90D0", VA = "0x90D0", Slot = "22")]
		protected override void OnShow(MagicTowerWindow.MagicTowerWindowArgs args)
		{
		/* --- GHIDRA: OnShow ---
		void Gameplay_Clans_Buildings_MagicTower_View_MagicTowerWindow__OnShow(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a57805 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_Buildings_BaseBuildingWindow_MagicTowerWindow_MagicTowerWindowArgs__ClanIsle__OnClose__
		              );
		    DAT_ram_00a57805 = '\x01';
		  }
		  UI_Windows_Buildings_BaseBuildingWindow_object____Il2CppFullySharedGenericType____ctor
		            (param1,
		             Method_UI_Windows_Buildings_BaseBuildingWindow_MagicTowerWindow_MagicTowerWindowArgs__ClanIsle__OnClose__
		            );
		  if (*(char *)(param1 + 0x70) != '\0') {
		    MVC_AbstractController__Run(*(undefined4 *)(param1 + 0x68),0);
		    iVar1 = **(int **)(param1 + 0x6c);
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0x130) * 4))
		              (*(int **)(param1 + 0x6c),*(undefined4 *)(iVar1 + 0x134));
		    iVar1 = **(int **)(param1 + 0x68);
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xe8) * 4))
		              (*(int **)(param1 + 0x68),*(undefined4 *)(iVar1 + 0xec));
		    iVar1 = **(int **)(param1 + 0x60);
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xe8) * 4))
		              (*(int **)(param1 + 0x60),*(undefined4 *)(iVar1 + 0xec));
		    *(undefined8 *)(param1 + 0x68) = 0;
		    *(undefined4 *)(param1 + 0x60) = 0;
		    *(undefined1 *)(param1 + 0x70) = 0;
		  }
		  return;
		}
		*/

		}

		// Token: 0x0600421D RID: 16925 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600421D")]
		[Address(RVA = "0x90D1", Offset = "0x90D1", VA = "0x90D1", Slot = "19")]
		protected override void OnClose()
		{
		/* --- GHIDRA: OnClose ---
		void Gameplay_Clans_Buildings_MagicTower_View_MagicTowerWindow__OnClose
		               (int param1,int *param2,undefined4 param3)
		
		{
		  bool bVar1;
		  uint uVar2;
		  int iVar3;
		  int iVar4;
		  uint *puVar5;
		  undefined4 uVar6;
		  int iVar7;
		  int iVar8;
		  int iVar9;
		  undefined4 uVar10;
		  undefined4 uVar11;
		  int iVar12;
		  int *piVar13;
		  
		  iVar12 = 0;
		  if (DAT_ram_00a57806 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ClanSpellListElement__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Clans_Buildings_MagicTower_View_ClanSpellListElement___TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_ICollection_SchoolSpellData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IList_SchoolSpellData__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Buildings_MagicTower_View_MagicTowerWindow_SelectEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Buildings_MagicTower_View_MagicTowerWindow_UseButtonClickedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Object_Instantiate_ClanSpellListElement___);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    DAT_ram_00a57806 = '\x01';
		  }
		  iVar9 = *(int *)(param1 + 0x4c);
		  if (0 < *(int *)(iVar9 + 0xc)) {
		    do {
		      iVar8 = *(int *)(iVar9 + iVar12 * 4 + 0x10);
		      uVar6 = unnamed_function_1417(System_Action_ClanSpellListElement__TypeInfo);
		      UnityEngine_UIElements_VisualElement__get_layout
		                (uVar6,param1,
		                 Method_Gameplay_Clans_Buildings_MagicTower_View_MagicTowerWindow_SelectEventHandler__
		                 ,0);
		      if (DAT_ram_00a577f2 == '\0') {
		        Mono_Security_ASN1__get_Item(&System_Action_ClanSpellListElement__TypeInfo);
		        DAT_ram_00a577f2 = '\x01';
		      }
		      iVar3 = *(int *)(iVar8 + 0x44);
		      do {
		        iVar7 = 0;
		        iVar4 = func_ii_7048(iVar3,uVar6,0);
		        uVar10 = System_Action_ClanSpellListElement__TypeInfo;
		        if ((iVar4 != 0) &&
		           (iVar7 = func_ii_1082(iVar4,System_Action_ClanSpellListElement__TypeInfo), iVar7 == 0)) {
		          System_Activator__CreateInstance(iVar4,uVar10);
		          do {
		            halt_trap();
		          } while( true );
		        }
		        iVar7 = func_ii_4329(iVar8 + 0x44,iVar7,iVar3);
		        bVar1 = iVar7 != iVar3;
		        iVar3 = iVar7;
		      } while (bVar1);
		      uVar6 = unnamed_function_1417(System_Action_ClanSpellListElement__TypeInfo);
		      UnityEngine_UIElements_VisualElement__get_layout
		                (uVar6,param1,
		                 Method_Gameplay_Clans_Buildings_MagicTower_View_MagicTowerWindow_UseButtonClickedEventHandler__
		                 ,0);
		      if (DAT_ram_00a577f4 == '\0') {
		        Mono_Security_ASN1__get_Item(&System_Action_ClanSpellListElement__TypeInfo);
		        DAT_ram_00a577f4 = '\x01';
		      }
		      iVar3 = *(int *)(iVar8 + 0x48);
		      do {
		        iVar7 = 0;
		        iVar4 = func_ii_7048(iVar3,uVar6,0);
		        uVar10 = System_Action_ClanSpellListElement__TypeInfo;
		        if ((iVar4 != 0) &&
		           (iVar7 = func_ii_1082(iVar4,System_Action_ClanSpellListElement__TypeInfo), iVar7 == 0)) {
		          System_Activator__CreateInstance(iVar4,uVar10);
		          do {
		            halt_trap();
		          } while( true );
		        }
		        iVar7 = func_ii_4329(iVar8 + 0x48,iVar7,iVar3);
		        bVar1 = iVar7 != iVar3;
		        iVar3 = iVar7;
		      } while (bVar1);
		      uVar6 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                        (iVar8,0);
		      if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		        func_ii_306000(UnityEngine_Object_TypeInfo);
		      }
		      UnityEngine_Application__get_isPlaying(uVar6,0);
		      iVar12 = iVar12 + 1;
		    } while (iVar12 < *(int *)(iVar9 + 0xc));
		  }
		  uVar2 = 0;
		  *(undefined4 *)(param1 + 0x5c) = 0;
		  iVar12 = *param2;
		  if (*(ushort *)(iVar12 + 0xb6) != 0) {
		    do {
		      if (System_Collections_Generic_ICollection_SchoolSpellData__TypeInfo ==
		          *(int *)(*(int *)(iVar12 + 0x58) + uVar2 * 8)) {
		        puVar5 = (uint *)(iVar12 + *(int *)(*(int *)(iVar12 + 0x58) + uVar2 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x80de2db4;
		      }
		      uVar2 = uVar2 + 1;
		    } while (*(ushort *)(iVar12 + 0xb6) != uVar2);
		  }
		  puVar5 = (uint *)func_ii_1080(param2,
		                                System_Collections_Generic_ICollection_SchoolSpellData__TypeInfo,0);
		code_r0x80de2db4:
		  uVar6 = (**(code **)((ulonglong)*puVar5 * 4))(param2,puVar5[1]);
		  uVar6 = Mono_Security_ASN1Convert__ToOid
		                    (Gameplay_Clans_Buildings_MagicTower_View_ClanSpellListElement___TypeInfo,uVar6)
		  ;
		  *(undefined4 *)(param1 + 0x4c) = uVar6;
		  iVar12 = 0;
		  do {
		    iVar9 = *param2;
		    if (*(ushort *)(iVar9 + 0xb6) != 0) {
		      uVar2 = 0;
		      do {
		        piVar13 = (int *)(*(int *)(iVar9 + 0x58) + uVar2 * 8);
		        if (System_Collections_Generic_ICollection_SchoolSpellData__TypeInfo == *piVar13) {
		          puVar5 = (uint *)(iVar9 + piVar13[1] * 8 + 0xc0);
		          goto code_r0x80de2e46;
		        }
		        uVar2 = uVar2 + 1;
		      } while (*(ushort *)(iVar9 + 0xb6) != uVar2);
		    }
		    puVar5 = (uint *)func_ii_1080(param2,
		                                  System_Collections_Generic_ICollection_SchoolSpellData__TypeInfo,0
		                                 );
		code_r0x80de2e46:
		    iVar9 = (**(code **)((ulonglong)*puVar5 * 4))(param2,puVar5[1]);
		    if (iVar9 <= iVar12) {
		      return;
		    }
		    iVar9 = *param2;
		    if (*(ushort *)(iVar9 + 0xb6) != 0) {
		      uVar2 = 0;
		      do {
		        piVar13 = (int *)(*(int *)(iVar9 + 0x58) + uVar2 * 8);
		        if (System_Collections_Generic_IList_SchoolSpellData__TypeInfo == *piVar13) {
		          puVar5 = (uint *)(iVar9 + piVar13[1] * 8 + 0xc0);
		          goto code_r0x80de2ec5;
		        }
		        uVar2 = uVar2 + 1;
		      } while (*(ushort *)(iVar9 + 0xb6) != uVar2);
		    }
		    puVar5 = (uint *)func_ii_1080(param2,System_Collections_Generic_IList_SchoolSpellData__TypeInfo,
		                                  0);
		code_r0x80de2ec5:
		    uVar6 = (**(code **)((ulonglong)*puVar5 * 4))(param2,iVar12,puVar5[1]);
		    uVar10 = *(undefined4 *)(param1 + 0x44);
		    uVar11 = *(undefined4 *)(param1 + 0x48);
		    if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		      func_ii_306000(UnityEngine_Object_TypeInfo);
		    }
		    iVar9 = func_ii_6805(uVar11,uVar10,Method_UnityEngine_Object_Instantiate_ClanSpellListElement___
		                        );
		    uVar10 = unnamed_function_1417(System_Action_ClanSpellListElement__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar10,param1,
		               Method_Gameplay_Clans_Buildings_MagicTower_View_MagicTowerWindow_SelectEventHandler__
		               ,0);
		    if (DAT_ram_00a577f1 == '\0') {
		      Mono_Security_ASN1__get_Item(&System_Action_ClanSpellListElement__TypeInfo);
		      DAT_ram_00a577f1 = '\x01';
		    }
		    iVar8 = *(int *)(iVar9 + 0x44);
		    do {
		      iVar3 = 0;
		      iVar7 = UnityEngine_UI_Image__set_sprite(iVar8,uVar10,0);
		      uVar11 = System_Action_ClanSpellListElement__TypeInfo;
		      if ((iVar7 != 0) &&
		         (iVar3 = func_ii_1082(iVar7,System_Action_ClanSpellListElement__TypeInfo), iVar3 == 0)) {
		        System_Activator__CreateInstance(iVar7,uVar11);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      iVar3 = func_ii_4329(iVar9 + 0x44,iVar3,iVar8);
		      bVar1 = iVar3 != iVar8;
		      iVar8 = iVar3;
		    } while (bVar1);
		    uVar10 = unnamed_function_1417(System_Action_ClanSpellListElement__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar10,param1,
		               Method_Gameplay_Clans_Buildings_MagicTower_View_MagicTowerWindow_UseButtonClickedEventHandler__
		               ,0);
		    if (DAT_ram_00a577f3 == '\0') {
		      Mono_Security_ASN1__get_Item(&System_Action_ClanSpellListElement__TypeInfo);
		      DAT_ram_00a577f3 = '\x01';
		    }
		    iVar8 = *(int *)(iVar9 + 0x48);
		    do {
		      iVar3 = 0;
		      iVar7 = UnityEngine_UI_Image__set_sprite(iVar8,uVar10,0);
		      uVar11 = System_Action_ClanSpellListElement__TypeInfo;
		      if ((iVar7 != 0) &&
		         (iVar3 = func_ii_1082(iVar7,System_Action_ClanSpellListElement__TypeInfo), iVar3 == 0)) {
		        System_Activator__CreateInstance(iVar7,uVar11);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      iVar3 = func_ii_4329(iVar9 + 0x48,iVar3,iVar8);
		      bVar1 = iVar3 != iVar8;
		      iVar8 = iVar3;
		    } while (bVar1);
		    *(undefined1 *)(iVar9 + 0x3c) = 0;
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (*(undefined4 *)(iVar9 + 0x24),0,0);
		    Gameplay_Clans_Buildings_MagicTower_View_ClanSpellListElement__OnDestroy(iVar9,uVar6,iVar3);
		    piVar13 = *(int **)(param1 + 0x4c);
		    iVar8 = func_ii_1082(iVar9,*(undefined4 *)(*piVar13 + 0x20));
		    if (iVar8 == 0) {
		      uVar6 = func_ii_1083();
		      func_ii_1050(uVar6,0);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    piVar13[iVar12 + 4] = iVar9;
		    iVar12 = iVar12 + 1;
		  } while( true );
		}
		*/

		}

		// Token: 0x0600421E RID: 16926 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600421E")]
		[Address(RVA = "0x90D2", Offset = "0x90D2", VA = "0x90D2")]
		public void Init(IList<SchoolSpellData> spells)
		{
		/* --- GHIDRA: Init ---
		void Gameplay_Clans_Buildings_MagicTower_View_MagicTowerWindow__Init
		               (int param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  iVar1 = *(int *)(param1 + 0x58);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(param2 + 0x40),
		               *(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x0600421F RID: 16927 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600421F")]
		[Address(RVA = "0x90D3", Offset = "0x90D3", VA = "0x90D3")]
		private void UseButtonClickedEventHandler(ClanSpellListElement element)
		{
		/* --- GHIDRA: UseButtonClickedEventHandler ---
		void Gameplay_Clans_Buildings_MagicTower_View_MagicTowerWindow__UseButtonClickedEventHandler
		               (int param1,int param2,undefined4 param3)
		
		{
		  char cVar1;
		  int iVar2;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a57807 == '\0') {
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    DAT_ram_00a57807 = '\x01';
		  }
		  param1_00 = *(undefined4 *)(param1 + 0x5c);
		  if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_Object_TypeInfo);
		  }
		  iVar2 = UnityEngine_TextCore_Text_TextElement__get_textAsset(param1_00,0,0);
		  if (iVar2 != 0) {
		    iVar2 = *(int *)(param1 + 0x5c);
		    *(undefined1 *)(iVar2 + 0x3c) = 0;
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (*(undefined4 *)(iVar2 + 0x24),0,0);
		  }
		  cVar1 = *(char *)(param2 + 0x3c);
		  iVar2 = param2;
		  if (cVar1 == '\0') {
		    iVar2 = 0;
		  }
		  *(int *)(param1 + 0x5c) = iVar2;
		  if (cVar1 == '\0') {
		    iVar2 = *(int *)(param1 + 0x54);
		    if (iVar2 != 0) {
		      (**(code **)((ulonglong)*(uint *)(iVar2 + 0xc) * 4))
		                (*(undefined4 *)(iVar2 + 0x20),*(undefined4 *)(iVar2 + 0x14));
		    }
		  }
		  else {
		    iVar2 = *(int *)(param1 + 0x50);
		    if (iVar2 != 0) {
		      (**(code **)((ulonglong)*(uint *)(iVar2 + 0xc) * 4))
		                (*(undefined4 *)(iVar2 + 0x20),*(undefined4 *)(param2 + 0x40),
		                 *(undefined4 *)(iVar2 + 0x14));
		      return;
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x06004220 RID: 16928 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004220")]
		[Address(RVA = "0x90D4", Offset = "0x90D4", VA = "0x90D4")]
		private void SelectEventHandler(ClanSpellListElement element)
		{
		/* --- GHIDRA: SelectEventHandler ---
		void Gameplay_Clans_Buildings_MagicTower_View_MagicTowerWindow__SelectEventHandler
		               (int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  int *piVar4;
		  int iVar5;
		  undefined4 uVar6;
		  int iVar7;
		  
		  if (DAT_ram_00a57808 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Windows_BaseWindow_MagicTowerWindow_MagicTowerWindowArgs__get_WindowArgs__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Clans_Buildings_MagicTower_Controller_MagicTowerController_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Clans_Buildings_MagicTower_Events_MagicTowerEvents_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Clans_Buildings_MagicTower_Model_MagicTowerModel_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Clans_Buildings_MagicTower_Controller_MagicTowerViewMediator_TypeInfo);
		    DAT_ram_00a57808 = '\x01';
		  }
		  if (*(char *)(param1 + 0x70) == '\0') {
		    if (DAT_ram_00a6456f == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		      DAT_ram_00a6456f = '\x01';
		    }
		    piVar4 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		    iVar5 = *piVar4;
		    if (*(ushort *)(iVar5 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		          puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0x140);
		          goto code_r0x80de269b;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(piVar4,Core_Gameplay_IGame_TypeInfo,0x10);
		code_r0x80de269b:
		    uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(piVar4,puVar2[1]);
		    uVar3 = func_ii_7112(uVar3,0);
		    iVar5 = func_ii_8093(param1,
		                         Method_UI_Windows_BaseWindow_MagicTowerWindow_MagicTowerWindowArgs__get_WindowArgs__
		                        );
		    uVar6 = *(undefined4 *)(iVar5 + 0x18);
		    iVar5 = unnamed_function_1417
		                      (Gameplay_Clans_Buildings_MagicTower_Model_MagicTowerModel_TypeInfo);
		    Gameplay_Clans_Buildings_MagicTower_Model_MagicTowerModel__Dispose(iVar5,uVar3,uVar6,uVar3);
		    if (DAT_ram_00a6456f == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		      DAT_ram_00a6456f = '\x01';
		    }
		    piVar4 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		    iVar7 = *piVar4;
		    if (*(ushort *)(iVar7 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		          puVar2 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + iVar7 + 0x248);
		          goto code_r0x80de2777;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(piVar4,Core_Gameplay_IGame_TypeInfo,0x31);
		code_r0x80de2777:
		    uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(piVar4,puVar2[1]);
		    *(undefined4 *)(iVar5 + 0x18) = uVar3;
		    *(int *)(param1 + 0x60) = iVar5;
		    uVar3 = unnamed_function_1417
		                      (Gameplay_Clans_Buildings_MagicTower_Events_MagicTowerEvents_TypeInfo);
		    *(undefined4 *)(param1 + 100) = uVar3;
		    uVar6 = *(undefined4 *)(param1 + 0x60);
		    iVar5 = unnamed_function_1417
		                      (Gameplay_Clans_Buildings_MagicTower_Controller_MagicTowerController_TypeInfo)
		    ;
		    if (DAT_ram_00a57811 == '\0') {
		      Mono_Security_ASN1__get_Item
		                (&Method_MVC_AbstractController_MagicTowerModel__MagicTowerEvents___ctor__);
		      Mono_Security_ASN1__get_Item(&Method_Core_Net_ServiceFactory_GetService_MagicTowerService___);
		      Mono_Security_ASN1__get_Item(&Core_Net_ServiceFactory_TypeInfo);
		      DAT_ram_00a57811 = '\x01';
		    }
		    Gameplay_Combat_AbstractCombat_object__object__object__object__object___set_User
		              (iVar5,uVar6,uVar3,
		               Method_MVC_AbstractController_MagicTowerModel__MagicTowerEvents___ctor__);
		    if (*(int *)(Core_Net_ServiceFactory_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Net_ServiceFactory_TypeInfo);
		    }
		    uVar3 = Core_Gameplay_Managers_LoggedManager__RequestLogin
		                      (Method_Core_Net_ServiceFactory_GetService_MagicTowerService___);
		    *(undefined4 *)(iVar5 + 0x18) = uVar3;
		    *(int *)(param1 + 0x68) = iVar5;
		    uVar3 = *(undefined4 *)(param1 + 0x60);
		    uVar6 = *(undefined4 *)(param1 + 100);
		    piVar4 = (int *)unnamed_function_1417
		                              (
		                              Gameplay_Clans_Buildings_MagicTower_Controller_MagicTowerViewMediator_TypeInfo
		                              );
		    if (DAT_ram_00a57824 == '\0') {
		      Mono_Security_ASN1__get_Item
		                (&
		                 Method_MVC_AbstractViewMediator_MagicTowerModel__MagicTowerEvents__MagicTowerController__MagicTowerWindow___ctor__
		                );
		      DAT_ram_00a57824 = '\x01';
		    }
		    Gameplay_Combat_TeamCombat_View_AbstractTeamCombatView_object___get_HideInstantElements
		              (piVar4,uVar3,uVar6,iVar5,
		               Method_MVC_AbstractViewMediator_MagicTowerModel__MagicTowerEvents__MagicTowerController__MagicTowerWindow___ctor__
		              );
		    (**(code **)((ulonglong)*(uint *)(*piVar4 + 0x160) * 4))
		              (piVar4,param1,*(undefined4 *)(*piVar4 + 0x164));
		    *(int **)(param1 + 0x6c) = piVar4;
		    MVC_AbstractController__Dispose(*(undefined4 *)(param1 + 0x68),0);
		    *(undefined1 *)(param1 + 0x70) = 1;
		  }
		  return;
		}
		*/

		}

		// Token: 0x06004221 RID: 16929 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004221")]
		[Address(RVA = "0x90D5", Offset = "0x90D5", VA = "0x90D5")]
		private void SetupMVC()
		{
		/* --- GHIDRA: SetupMVC ---
		void Gameplay_Clans_Buildings_MagicTower_View_MagicTowerWindow__SetupMVC
		               (int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  if (*(char *)(param1 + 0x70) != '\0') {
		    MVC_AbstractController__Run(*(undefined4 *)(param1 + 0x68),0);
		    iVar1 = **(int **)(param1 + 0x6c);
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0x130) * 4))
		              (*(int **)(param1 + 0x6c),*(undefined4 *)(iVar1 + 0x134));
		    iVar1 = **(int **)(param1 + 0x68);
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xe8) * 4))
		              (*(int **)(param1 + 0x68),*(undefined4 *)(iVar1 + 0xec));
		    iVar1 = **(int **)(param1 + 0x60);
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xe8) * 4))
		              (*(int **)(param1 + 0x60),*(undefined4 *)(iVar1 + 0xec));
		    *(undefined8 *)(param1 + 0x68) = 0;
		    *(undefined4 *)(param1 + 0x60) = 0;
		    *(undefined1 *)(param1 + 0x70) = 0;
		  }
		  return;
		}
		*/

		}

		// Token: 0x06004222 RID: 16930 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004222")]
		[Address(RVA = "0x90D6", Offset = "0x90D6", VA = "0x90D6")]
		private void DestroyMVC()
		{
		/* --- GHIDRA: DestroyMVC ---
		void Gameplay_Clans_Buildings_MagicTower_View_MagicTowerWindow__DestroyMVC
		               (int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a57809 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_Buildings_BaseClanBuildingWindow_MagicTowerWindow_MagicTowerWindowArgs___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Clans_Buildings_MagicTower_View_ClanSpellListElement___TypeInfo);
		    DAT_ram_00a57809 = '\x01';
		  }
		  uVar1 = Mono_Security_ASN1Convert__ToOid
		                    (Gameplay_Clans_Buildings_MagicTower_View_ClanSpellListElement___TypeInfo,0);
		  *(undefined4 *)(param1 + 0x4c) = uVar1;
		  UI_Windows_Buildings_BaseBuildingWindow_object____Il2CppFullySharedGenericType___OnShow
		            (param1,
		             Method_UI_Windows_Buildings_BaseClanBuildingWindow_MagicTowerWindow_MagicTowerWindowArgs___ctor__
		            );
		  return;
		}
		*/

		}

		// Token: 0x06004223 RID: 16931 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004223")]
		[Address(RVA = "0x90D7", Offset = "0x90D7", VA = "0x90D7")]
		public MagicTowerWindow()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Clans_Buildings_MagicTower_View_MagicTowerWindow___ctor
		               (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  UI_Windows_Buildings_BaseBuildingWindowArgs___ctor(param1,param2,param3,0);
		  return;
		}
		*/

		}

		// Token: 0x04002478 RID: 9336
		[Token(Token = "0x4002478")]
		public const string WINDOW_ID = "Prefabs/UI/Windows/Clans/Buildings/MagicTowerWindow";

		// Token: 0x04002479 RID: 9337
		[Token(Token = "0x4002479")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private TitledListWithSpellTitle _titledList;

		// Token: 0x0400247A RID: 9338
		[Token(Token = "0x400247A")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private RectTransform _content;

		// Token: 0x0400247B RID: 9339
		[Token(Token = "0x400247B")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private ClanSpellListElement _listElementPrefab;

		// Token: 0x04002480 RID: 9344
		[Token(Token = "0x4002480")]
		[FieldOffset(Offset = "0x5C")]
		private ClanSpellListElement _selectedElement;

		// Token: 0x04002481 RID: 9345
		[Token(Token = "0x4002481")]
		[FieldOffset(Offset = "0x60")]
		private MagicTowerModel _model;

		// Token: 0x04002482 RID: 9346
		[Token(Token = "0x4002482")]
		[FieldOffset(Offset = "0x64")]
		private MagicTowerEvents _events;

		// Token: 0x04002483 RID: 9347
		[Token(Token = "0x4002483")]
		[FieldOffset(Offset = "0x68")]
		private MagicTowerController _controller;

		// Token: 0x04002484 RID: 9348
		[Token(Token = "0x4002484")]
		[FieldOffset(Offset = "0x6C")]
		private MagicTowerViewMediator _mediator;

		// Token: 0x04002485 RID: 9349
		[Token(Token = "0x4002485")]
		[FieldOffset(Offset = "0x70")]
		private bool _mvcSetup;

		// Token: 0x02000AB4 RID: 2740
		[Token(Token = "0x2000AB4")]
		public class MagicTowerWindowArgs : BaseClanBuildingWindowArgs
		{
			// Token: 0x06004224 RID: 16932 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6004224")]
			[Address(RVA = "0x90D8", Offset = "0x90D8", VA = "0x90D8")]
			public MagicTowerWindowArgs(ClanIsle isle, uint buildingTypeId)
			{
			}
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_Spells ---
		void Gameplay_Clans_Buildings_MagicTower_View_MagicTowerWindow__set_Spells
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a577fe == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_SchoolSpellData__TypeInfo);
		    DAT_ram_00a577fe = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x50);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_SchoolSpellData__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_SchoolSpellData__TypeInfo), iVar2 == 0)) break;
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


		/* --- GHIDRA: add_SelectSpellEvent ---
		void Gameplay_Clans_Buildings_MagicTower_View_MagicTowerWindow__add_SelectSpellEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a577ff == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_SchoolSpellData__TypeInfo);
		    DAT_ram_00a577ff = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x50);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_SchoolSpellData__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_SchoolSpellData__TypeInfo), iVar2 == 0)) break;
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


		/* --- GHIDRA: remove_SelectSpellEvent ---
		void Gameplay_Clans_Buildings_MagicTower_View_MagicTowerWindow__remove_SelectSpellEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  int param1_00;
		  int *param1_01;
		  int iVar2;
		  
		  if (DAT_ram_00a57800 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    DAT_ram_00a57800 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x54);
		  while ((param1_01 = (int *)UnityEngine_UI_Image__set_sprite(param1_00,param2,0),
		         param1_01 == (int *)0x0 || (System_Action_TypeInfo == *param1_01))) {
		    iVar2 = func_ii_4329(param1 + 0x54,param1_01,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,System_Action_TypeInfo);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/


		/* --- GHIDRA: add_DeselectSpellEvent ---
		void Gameplay_Clans_Buildings_MagicTower_View_MagicTowerWindow__add_DeselectSpellEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  int param1_00;
		  int *param1_01;
		  int iVar2;
		  
		  if (DAT_ram_00a57801 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    DAT_ram_00a57801 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x54);
		  while ((param1_01 = (int *)func_ii_7048(param1_00,param2,0), param1_01 == (int *)0x0 ||
		         (System_Action_TypeInfo == *param1_01))) {
		    iVar2 = func_ii_4329(param1 + 0x54,param1_01,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,System_Action_TypeInfo);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/


		/* --- GHIDRA: remove_DeselectSpellEvent ---
		void Gameplay_Clans_Buildings_MagicTower_View_MagicTowerWindow__remove_DeselectSpellEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a57802 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_SchoolSpellData__TypeInfo);
		    DAT_ram_00a57802 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x58);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_SchoolSpellData__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_SchoolSpellData__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0x58,iVar2,param1_00);
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


		/* --- GHIDRA: add_UseSpellButtonClickedEvent ---
		void Gameplay_Clans_Buildings_MagicTower_View_MagicTowerWindow__add_UseSpellButtonClickedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a57803 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_SchoolSpellData__TypeInfo);
		    DAT_ram_00a57803 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x58);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_SchoolSpellData__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_SchoolSpellData__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0x58,iVar2,param1_00);
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


		/* --- GHIDRA: remove_UseSpellButtonClickedEvent ---
		void Gameplay_Clans_Buildings_MagicTower_View_MagicTowerWindow__remove_UseSpellButtonClickedEvent
		               (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  if (DAT_ram_00a57804 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_Buildings_BaseBuildingWindow_MagicTowerWindow_MagicTowerWindowArgs__ClanIsle__OnShow__
		              );
		    DAT_ram_00a57804 = '\x01';
		  }
		  UI_Windows_Buildings_BaseBuildingWindow_object__object___OnClose
		            (param1,param2,
		             Method_UI_Windows_Buildings_BaseBuildingWindow_MagicTowerWindow_MagicTowerWindowArgs__ClanIsle__OnShow__
		            );
		  Gameplay_Clans_Buildings_MagicTower_View_MagicTowerWindow__SelectEventHandler(param1,param1);
		  return;
		}
		*/

}
