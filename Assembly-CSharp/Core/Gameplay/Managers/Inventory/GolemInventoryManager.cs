using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Core.Data;
using Gameplay.ArtifactComparer.Controller;
using Gameplay.ArtifactComparer.Model;
using Gameplay.Clans.Buildings.Golem.Controller;
using Gameplay.Clans.Buildings.Golem.Events;
using Gameplay.Clans.Buildings.Golem.Model;
using Gameplay.Inventory.Events;
using Gameplay.Inventory.Model;
using Gameplay.Inventory.View.Chest;
using Gameplay.Isles.Clan;
using Gameplay.Isles.Clan.Events;
using Il2CppDummyDll;
using Protocol.Dic;

namespace Core.Gameplay.Managers.Inventory
{
	// Token: 0x020011BF RID: 4543
	[Token(Token = "0x20011BF")]
	public class GolemInventoryManager : IGameManager, IBaseManager, IInventoryManager
	{
		// Token: 0x17001610 RID: 5648
		// (get) Token: 0x06006C04 RID: 27652 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001610")]
		public string Name
		{
			[Token(Token = "0x6006C04")]
			[Address(RVA = "0xB6F3", Offset = "0xB6F3", VA = "0xB6F3", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x140002C3 RID: 707
		// (add) Token: 0x06006C05 RID: 27653 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06006C06 RID: 27654 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140002C3")]
		public event Action<IBaseManager> InitCompleteEvent
		{
			[Token(Token = "0x6006C05")]
			[Address(RVA = "0xB6F4", Offset = "0xB6F4", VA = "0xB6F4", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6006C06")]
			[Address(RVA = "0xB6F5", Offset = "0xB6F5", VA = "0xB6F5", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x140002C4 RID: 708
		// (add) Token: 0x06006C07 RID: 27655 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06006C08 RID: 27656 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140002C4")]
		public event Action<IBaseManager> DeinitCompleteEvent
		{
			[Token(Token = "0x6006C07")]
			[Address(RVA = "0xB6F6", Offset = "0xB6F6", VA = "0xB6F6", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6006C08")]
			[Address(RVA = "0xB6F7", Offset = "0xB6F7", VA = "0xB6F7", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x17001611 RID: 5649
		// (get) Token: 0x06006C09 RID: 27657 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06006C0A RID: 27658 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001611")]
		public GolemInventoryModel Model
		{
			[Token(Token = "0x6006C09")]
			[Address(RVA = "0xB6F8", Offset = "0xB6F8", VA = "0xB6F8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006C0A")]
			[Address(RVA = "0xB6F9", Offset = "0xB6F9", VA = "0xB6F9")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17001612 RID: 5650
		// (get) Token: 0x06006C0B RID: 27659 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06006C0C RID: 27660 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001612")]
		public GolemInventoryController Controller
		{
			[Token(Token = "0x6006C0B")]
			[Address(RVA = "0xB6FA", Offset = "0xB6FA", VA = "0xB6FA")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006C0C")]
			[Address(RVA = "0xB6FB", Offset = "0xB6FB", VA = "0xB6FB")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17001613 RID: 5651
		// (get) Token: 0x06006C0D RID: 27661 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001613")]
		public GolemInventoryEvents Events
		{
			[Token(Token = "0x6006C0D")]
			[Address(RVA = "0xB6FC", Offset = "0xB6FC", VA = "0xB6FC")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x17001614 RID: 5652
		// (get) Token: 0x06006C0E RID: 27662 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001614")]
		private InventoryBaseModel Model
		{
			[Token(Token = "0x6006C0E")]
			[Address(RVA = "0xB6FD", Offset = "0xB6FD", VA = "0xB6FD", Slot = "11")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001615 RID: 5653
		// (get) Token: 0x06006C0F RID: 27663 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001615")]
		private InventoryBaseEvents Events
		{
			[Token(Token = "0x6006C0F")]
			[Address(RVA = "0xB6FE", Offset = "0xB6FE", VA = "0xB6FE", Slot = "12")]
			get
			{
				return null;
			}
		}

		// Token: 0x06006C10 RID: 27664 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006C10")]
		[Address(RVA = "0xB6FF", Offset = "0xB6FF", VA = "0xB6FF")]
		public GolemInventoryManager(IGame game)
		{
		/* --- GHIDRA: <SellItem>b__44_0 ---
		void Core_Gameplay_Managers_Inventory_GolemInventoryManager___SellItem_b__44_0
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5a6c7 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a5a6c7 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 8);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_IBaseManager__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_IBaseManager__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 8,iVar2,param1_00);
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

		/* --- GHIDRA: .ctor ---
		void Core_Gameplay_Managers_Inventory_GolemInventoryManager___ctor
		               (int param1,int param2,undefined4 param3)
		
		{
		  if (DAT_ram_00a5a6bb == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Isles_Base_AbstractIsle_ClanIsleEvents__ClanIsleModel__ClanIsleController__ClanBuildingTypes__get_Events__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Isles_Base_AbstractIsle_ClanIsleEvents__ClanIsleModel__ClanIsleController__ClanBuildingTypes__get_Model__
		              );
		    DAT_ram_00a5a6bb = '\x01';
		  }
		  if (*(int *)(param1 + 0x30) != 0) {
		    Core_Gameplay_Managers_Inventory_GolemInventoryManager__set_ClanIsle(param1,0,param1);
		  }
		  *(int *)(param1 + 0x30) = param2;
		  if ((param2 != 0) &&
		     (Core_Gameplay_Managers_Inventory_GolemInventoryManager__set_ClanIsle
		                (param1,*(undefined4 *)(param2 + 0xc),param1),
		     *(int *)(*(int *)(*(int *)(*(int *)(param1 + 0x30) + 0x10) + 0x38) + 0x20) != 0)) {
		    Core_Gameplay_Managers_Inventory_GolemInventoryManager__BuildingStateChangedEventHandler
		              (param1,param1);
		  }
		  return;
		}
		*/

		}

		// Token: 0x17001616 RID: 5654
		// (set) Token: 0x06006C11 RID: 27665 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001616")]
		private ClanIsle ClanIsle
		{
			[Token(Token = "0x6006C11")]
			[Address(RVA = "0xB700", Offset = "0xB700", VA = "0xB700")]
			set
			{
			}
		}

		// Token: 0x17001617 RID: 5655
		// (set) Token: 0x06006C12 RID: 27666 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001617")]
		private ClanIsleEvents ClanIsleEvents
		{
			[Token(Token = "0x6006C12")]
			[Address(RVA = "0xB701", Offset = "0xB701", VA = "0xB701")]
			set
			{
			}
		}

		// Token: 0x06006C13 RID: 27667 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006C13")]
		[Address(RVA = "0xB702", Offset = "0xB702", VA = "0xB702")]
		private void BuildingStateChangedEventHandler(uint type)
		{
		/* --- GHIDRA: BuildingStateChangedEventHandler ---
		void Core_Gameplay_Managers_Inventory_GolemInventoryManager__BuildingStateChangedEventHandler
		               (int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  int iVar4;
		  int *piVar5;
		  int iVar6;
		  int iVar7;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a5a6be == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Isles_Base_AbstractIsle_ClanIsleEvents__ClanIsleModel__ClanIsleController__ClanBuildingTypes__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_ulong__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Gameplay_Managers_Inventory_GolemInventoryManager_LocationChangedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a5a6be = '\x01';
		  }
		  piVar5 = *(int **)(param1 + 0x1c);
		  iVar6 = *piVar5;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 0x230);
		        goto code_r0x81257f47;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar5,Core_Gameplay_IGame_TypeInfo,0x2e);
		code_r0x81257f47:
		  uVar1 = 0;
		  iVar6 = (**(code **)((ulonglong)*puVar2 * 4))(piVar5,puVar2[1]);
		  Gameplay_Clans_Model_ClansModel__DissociateClanFromUser
		            (*(undefined4 *)(iVar6 + 0x10),
		             *(undefined4 *)(*(int *)(*(int *)(param1 + 0x30) + 0x10) + 0x38),0);
		  piVar5 = *(int **)(param1 + 0x1c);
		  iVar6 = *piVar5;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 0x110);
		        goto code_r0x81257fde;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar5,Core_Gameplay_IGame_TypeInfo,10);
		code_r0x81257fde:
		  iVar6 = (**(code **)((ulonglong)*puVar2 * 4))(piVar5,puVar2[1]);
		  iVar7 = *(int *)(iVar6 + 0xc);
		  param1_00 = *(undefined4 *)(iVar7 + 0x1c);
		  uVar3 = unnamed_function_1417(System_Action_ulong__TypeInfo);
		  func_ii_6877(uVar3,param1,
		               Method_Core_Gameplay_Managers_Inventory_GolemInventoryManager_LocationChangedEventHandler__
		               ,0);
		  iVar6 = func_ii_7048(param1_00,uVar3,0);
		  uVar3 = System_Action_ulong__TypeInfo;
		  if (iVar6 == 0) {
		    *(undefined4 *)(iVar7 + 0x1c) = 0;
		  }
		  else {
		    iVar4 = func_ii_1082(iVar6,System_Action_ulong__TypeInfo);
		    if (iVar4 == 0) {
		      System_Activator__CreateInstance(iVar6,uVar3);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar7 + 0x1c) = iVar4;
		    uVar3 = System_Action_ulong__TypeInfo;
		    iVar7 = func_ii_1082(iVar6,System_Action_ulong__TypeInfo);
		    if (iVar7 == 0) {
		      System_Activator__CreateInstance(iVar6,uVar3);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  Core_Gameplay_Managers_Inventory_GolemInventoryManager___ctor(param1,0,iVar6);
		  Core_Gameplay_Managers_Inventory_GolemInventoryManager__ControllerInitEventHandler(param1,iVar6);
		  Core_Gameplay_Managers_Inventory_GolemInventoryManager__Deinit(param1,iVar6);
		  return;
		}
		*/

		}

		// Token: 0x06006C14 RID: 27668 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006C14")]
		[Address(RVA = "0xB703", Offset = "0xB703", VA = "0xB703")]
		private void HandleGolemCreated()
		{
		/* --- GHIDRA: HandleGolemCreated ---
		void Core_Gameplay_Managers_Inventory_GolemInventoryManager__HandleGolemCreated
		               (int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  int iVar4;
		  int *param1_00;
		  int iVar5;
		  int iVar6;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a5a6bf == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ulong__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Gameplay_Managers_Inventory_GolemInventoryManager_LocationChangedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a5a6bf = '\x01';
		  }
		  param1_00 = *(int **)(param1 + 0x1c);
		  iVar5 = *param1_00;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0x110);
		        goto code_r0x81258ca7;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,10);
		code_r0x81258ca7:
		  iVar5 = (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		  iVar6 = *(int *)(iVar5 + 0xc);
		  param1_01 = *(undefined4 *)(iVar6 + 0x1c);
		  uVar3 = unnamed_function_1417(System_Action_ulong__TypeInfo);
		  func_ii_6877(uVar3,param1,
		               Method_Core_Gameplay_Managers_Inventory_GolemInventoryManager_LocationChangedEventHandler__
		               ,0);
		  iVar5 = func_ii_7048(param1_01,uVar3,0);
		  uVar3 = System_Action_ulong__TypeInfo;
		  if (iVar5 == 0) {
		    *(undefined4 *)(iVar6 + 0x1c) = 0;
		  }
		  else {
		    iVar4 = func_ii_1082(iVar5,System_Action_ulong__TypeInfo);
		    if (iVar4 == 0) {
		      System_Activator__CreateInstance(iVar5,uVar3);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar6 + 0x1c) = iVar4;
		    uVar3 = System_Action_ulong__TypeInfo;
		    iVar6 = func_ii_1082(iVar5,System_Action_ulong__TypeInfo);
		    if (iVar6 == 0) {
		      System_Activator__CreateInstance(iVar5,uVar3);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  Core_Gameplay_Managers_Inventory_GolemInventoryManager__ControllerInitEventHandler(param1,iVar5);
		  Core_Gameplay_Managers_Inventory_GolemInventoryManager__Deinit(param1,iVar5);
		  return;
		}
		*/

		}

		// Token: 0x06006C15 RID: 27669 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006C15")]
		[Address(RVA = "0xB704", Offset = "0xB704", VA = "0xB704")]
		private void UserClanStatusChangedEventHandler()
		{
		/* --- GHIDRA: UserClanStatusChangedEventHandler ---
		void Core_Gameplay_Managers_Inventory_GolemInventoryManager__UserClanStatusChangedEventHandler
		               (int param1,longlong param2,undefined4 param3)
		
		{
		  uint *puVar1;
		  undefined4 param1_00;
		  int *piVar2;
		  int iVar3;
		  uint uVar4;
		  
		  if (DAT_ram_00a5a6c0 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a5a6c0 = '\x01';
		  }
		  piVar2 = *(int **)(param1 + 0x1c);
		  iVar3 = *piVar2;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    uVar4 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar4 * 8)) {
		        puVar1 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar4 * 8 + 4) * 8 + iVar3 + 0x110);
		        goto code_r0x81258de5;
		      }
		      uVar4 = uVar4 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar4);
		  }
		  puVar1 = (uint *)func_ii_1080(piVar2,Core_Gameplay_IGame_TypeInfo,10);
		code_r0x81258de5:
		  iVar3 = (**(code **)((ulonglong)*puVar1 * 4))(piVar2,puVar1[1]);
		  if (*(int *)(*(int *)(iVar3 + 0x14) + 0x1c) == 2) {
		    uVar4 = 0;
		    piVar2 = *(int **)(param1 + 0x1c);
		    iVar3 = *piVar2;
		    if (*(ushort *)(iVar3 + 0xb6) != 0) {
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar4 * 8)) {
		          puVar1 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar4 * 8 + 4) * 8 + iVar3 + 0x140);
		          goto code_r0x81258e75;
		        }
		        uVar4 = uVar4 + 1;
		      } while (*(ushort *)(iVar3 + 0xb6) != uVar4);
		    }
		    puVar1 = (uint *)func_ii_1080(piVar2,Core_Gameplay_IGame_TypeInfo,0x10);
		code_r0x81258e75:
		    param1_00 = (**(code **)((ulonglong)*puVar1 * 4))(piVar2,puVar1[1]);
		    iVar3 = func_ii_7112(param1_00,0);
		    if (*(longlong *)(*(int *)(*(int *)(iVar3 + 0x34) + 0x40) + 0x10) == param2) {
		      piVar2 = *(int **)(param1 + 0x1c);
		      iVar3 = *piVar2;
		      if (*(ushort *)(iVar3 + 0xb6) != 0) {
		        uVar4 = 0;
		        do {
		          if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar4 * 8)) {
		            puVar1 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar4 * 8 + 4) * 8 + iVar3 + 0x110);
		            goto code_r0x81258f4e;
		          }
		          uVar4 = uVar4 + 1;
		        } while (*(ushort *)(iVar3 + 0xb6) != uVar4);
		      }
		      puVar1 = (uint *)func_ii_1080(piVar2,Core_Gameplay_IGame_TypeInfo,10);
		code_r0x81258f4e:
		      iVar3 = (**(code **)((ulonglong)*puVar1 * 4))(piVar2,puVar1[1]);
		      iVar3 = *(int *)(*(int *)(iVar3 + 0x14) + 0x28);
		      if (DAT_ram_00a5a6bb == '\0') {
		        Mono_Security_ASN1__get_Item
		                  (&
		                   Method_Gameplay_Isles_Base_AbstractIsle_ClanIsleEvents__ClanIsleModel__ClanIsleController__ClanBuildingTypes__get_Events__
		                  );
		        Mono_Security_ASN1__get_Item
		                  (&
		                   Method_Gameplay_Isles_Base_AbstractIsle_ClanIsleEvents__ClanIsleModel__ClanIsleController__ClanBuildingTypes__get_Model__
		                  );
		        DAT_ram_00a5a6bb = '\x01';
		      }
		      if (*(int *)(param1 + 0x30) != 0) {
		        Core_Gameplay_Managers_Inventory_GolemInventoryManager__set_ClanIsle(param1,0,iVar3);
		      }
		      *(int *)(param1 + 0x30) = iVar3;
		      if ((iVar3 != 0) &&
		         (Core_Gameplay_Managers_Inventory_GolemInventoryManager__set_ClanIsle
		                    (param1,*(undefined4 *)(iVar3 + 0xc),iVar3),
		         *(int *)(*(int *)(*(int *)(*(int *)(param1 + 0x30) + 0x10) + 0x38) + 0x20) != 0)) {
		        Core_Gameplay_Managers_Inventory_GolemInventoryManager__BuildingStateChangedEventHandler
		                  (param1,iVar3);
		      }
		      return;
		    }
		  }
		  if (DAT_ram_00a5a6bb == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Isles_Base_AbstractIsle_ClanIsleEvents__ClanIsleModel__ClanIsleController__ClanBuildingTypes__get_Events__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Isles_Base_AbstractIsle_ClanIsleEvents__ClanIsleModel__ClanIsleController__ClanBuildingTypes__get_Model__
		              );
		    DAT_ram_00a5a6bb = '\x01';
		  }
		  if (*(int *)(param1 + 0x30) != 0) {
		    Core_Gameplay_Managers_Inventory_GolemInventoryManager__set_ClanIsle(param1,0,puVar1);
		  }
		  *(undefined4 *)(param1 + 0x30) = 0;
		  return;
		}
		*/

		}

		// Token: 0x06006C16 RID: 27670 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006C16")]
		[Address(RVA = "0xB705", Offset = "0xB705", VA = "0xB705")]
		private void LocationChangedEventHandler(ulong isleId)
		{
		/* --- GHIDRA: LocationChangedEventHandler ---
		void Core_Gameplay_Managers_Inventory_GolemInventoryManager__LocationChangedEventHandler
		               (int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  int *param1_01;
		  int iVar1;
		  undefined4 param1_02;
		  int iVar2;
		  
		  if (DAT_ram_00a5a6c1 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Gameplay_Managers_Inventory_GolemInventoryManager_ControllerInitEventHandler__
		              );
		    DAT_ram_00a5a6c1 = '\x01';
		  }
		  *(undefined1 *)(param1 + 0x34) = 1;
		  iVar1 = *(int *)(param1 + 0x18);
		  param1_02 = *(undefined4 *)(iVar1 + 8);
		  param1_00 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (param1_00,param1,
		             Method_Core_Gameplay_Managers_Inventory_GolemInventoryManager_ControllerInitEventHandler__
		             ,0);
		  param1_01 = (int *)func_ii_7048(param1_02,param1_00,0);
		  iVar2 = System_Action_TypeInfo;
		  if (param1_01 == (int *)0x0) {
		    *(undefined4 *)(iVar1 + 8) = 0;
		  }
		  else if ((System_Action_TypeInfo != *param1_01) ||
		          (*(int **)(iVar1 + 8) = param1_01, *param1_01 != iVar2)) {
		    System_Activator__CreateInstance(param1_01,iVar2);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  iVar2 = *(int *)(param1 + 8);
		  if (iVar2 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar2 + 0xc) * 4))
		              (*(undefined4 *)(iVar2 + 0x20),param1,*(undefined4 *)(iVar2 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06006C17 RID: 27671 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006C17")]
		[Address(RVA = "0xB706", Offset = "0xB706", VA = "0xB706")]
		private void ControllerInitEventHandler()
		{
		/* --- GHIDRA: ControllerInitEventHandler ---
		void Core_Gameplay_Managers_Inventory_GolemInventoryManager__ControllerInitEventHandler
		               (int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 param1_00;
		  int *piVar3;
		  int iVar4;
		  int iVar5;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a5a6c2 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Gameplay_Managers_Inventory_GolemInventoryManager_UserClanStatusChangedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a5a6c2 = '\x01';
		  }
		  piVar3 = *(int **)(param1 + 0x1c);
		  iVar4 = *piVar3;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0x230);
		        goto code_r0x81258136;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar3,Core_Gameplay_IGame_TypeInfo,0x2e);
		code_r0x81258136:
		  iVar4 = (**(code **)((ulonglong)*puVar2 * 4))(piVar3,puVar2[1]);
		  iVar5 = *(int *)(iVar4 + 0x14);
		  param1_01 = *(undefined4 *)(iVar5 + 0x18);
		  param1_00 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (param1_00,param1,
		             Method_Core_Gameplay_Managers_Inventory_GolemInventoryManager_UserClanStatusChangedEventHandler__
		             ,0);
		  piVar3 = (int *)func_ii_7048(param1_01,param1_00,0);
		  iVar4 = System_Action_TypeInfo;
		  if (piVar3 == (int *)0x0) {
		    *(undefined4 *)(iVar5 + 0x18) = 0;
		  }
		  else if ((System_Action_TypeInfo != *piVar3) ||
		          (*(int **)(iVar5 + 0x18) = piVar3, *piVar3 != iVar4)) {
		    System_Activator__CreateInstance(piVar3,iVar4);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  Core_Gameplay_Managers_Inventory_GolemInventoryManager___ctor(param1,0,piVar3);
		  if (*(char *)(param1 + 0x34) != '\0') {
		    *(undefined1 *)(param1 + 0x34) = 0;
		    MVC_AbstractController__Run(*(undefined4 *)(param1 + 0x14),0);
		    iVar4 = **(int **)(param1 + 0x10);
		    (**(code **)((ulonglong)*(uint *)(iVar4 + 0xe8) * 4))
		              (*(int **)(param1 + 0x10),*(undefined4 *)(iVar4 + 0xec));
		    iVar4 = **(int **)(param1 + 0x14);
		    (**(code **)((ulonglong)*(uint *)(iVar4 + 0xe8) * 4))
		              (*(int **)(param1 + 0x14),*(undefined4 *)(iVar4 + 0xec));
		    *(undefined8 *)(param1 + 0x10) = 0;
		  }
		  iVar4 = *(int *)(param1 + 0xc);
		  if (iVar4 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar4 + 0xc) * 4))
		              (*(undefined4 *)(iVar4 + 0x20),param1,*(undefined4 *)(iVar4 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06006C18 RID: 27672 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006C18")]
		[Address(RVA = "0xB707", Offset = "0xB707", VA = "0xB707", Slot = "9")]
		public void Deinit()
		{
		/* --- GHIDRA: Deinit ---
		void Core_Gameplay_Managers_Inventory_GolemInventoryManager__Deinit(int param1,undefined4 param2)
		
		{
		  uint *puVar1;
		  undefined4 uVar2;
		  int iVar3;
		  int *piVar4;
		  undefined4 uVar5;
		  undefined4 uVar6;
		  undefined4 uVar7;
		  int *piVar8;
		  int iVar9;
		  int iVar10;
		  undefined4 uVar11;
		  undefined4 uVar12;
		  uint uVar13;
		  uint uVar14;
		  
		  if (DAT_ram_00a5a6c3 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ulong__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_ArtifactComparer_Controller_ArtifactComparerController_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_ArtifactComparer_Controller_ArtifactComparerEvents_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_ArtifactComparer_Model_ArtifactComparerModel_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_Clans_Buildings_Golem_Controller_Middlewares_GolemInventoryActionsMiddleware_TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Clans_Buildings_Golem_Controller_GolemInventoryController_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Gameplay_Managers_Inventory_GolemInventoryManager_ControllerInitEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Gameplay_Managers_Inventory_GolemInventoryManager_LocationChangedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Gameplay_Managers_Inventory_GolemInventoryManager_UserClanStatusChangedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item(&Gameplay_Clans_Buildings_Golem_Model_GolemInventoryModel_TypeInfo)
		    ;
		    Mono_Security_ASN1__get_Item(&Core_Application_IApp_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_ServiceFactory_GetService_ClansService___);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_ServiceFactory_GetService_CraftService___);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_ServiceFactory_GetService_ServicesService___);
		    Mono_Security_ASN1__get_Item(&Core_Net_ServiceFactory_TypeInfo);
		    DAT_ram_00a5a6c3 = '\x01';
		  }
		  piVar8 = *(int **)(param1 + 0x1c);
		  iVar9 = *piVar8;
		  if (*(ushort *)(iVar9 + 0xb6) != 0) {
		    uVar14 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar9 + 0x58) + uVar14 * 8)) {
		        puVar1 = (uint *)(*(int *)(*(int *)(iVar9 + 0x58) + uVar14 * 8 + 4) * 8 + iVar9 + 0x230);
		        goto code_r0x8125834e;
		      }
		      uVar14 = uVar14 + 1;
		    } while (*(ushort *)(iVar9 + 0xb6) != uVar14);
		  }
		  puVar1 = (uint *)func_ii_1080(piVar8,Core_Gameplay_IGame_TypeInfo,0x2e);
		code_r0x8125834e:
		  iVar9 = (**(code **)((ulonglong)*puVar1 * 4))(piVar8,puVar1[1]);
		  iVar10 = *(int *)(iVar9 + 0x14);
		  uVar11 = *(undefined4 *)(iVar10 + 0x18);
		  uVar2 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar2,param1,
		             Method_Core_Gameplay_Managers_Inventory_GolemInventoryManager_UserClanStatusChangedEventHandler__
		             ,0);
		  piVar8 = (int *)UnityEngine_UI_Image__set_sprite(uVar11,uVar2,0);
		  iVar9 = System_Action_TypeInfo;
		  if (piVar8 == (int *)0x0) {
		    *(undefined4 *)(iVar10 + 0x18) = 0;
		  }
		  else if ((System_Action_TypeInfo != *piVar8) ||
		          (*(int **)(iVar10 + 0x18) = piVar8, *piVar8 != iVar9)) {
		    System_Activator__CreateInstance(piVar8,iVar9);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  if (*(char *)(param1 + 0x34) == '\0') {
		    uVar14 = 0;
		    piVar8 = *(int **)(param1 + 0x1c);
		    iVar9 = *piVar8;
		    if (*(ushort *)(iVar9 + 0xb6) != 0) {
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar9 + 0x58) + uVar14 * 8)) {
		          puVar1 = (uint *)(*(int *)(*(int *)(iVar9 + 0x58) + uVar14 * 8 + 4) * 8 + iVar9 + 0x230);
		          goto code_r0x81258448;
		        }
		        uVar14 = uVar14 + 1;
		      } while (*(ushort *)(iVar9 + 0xb6) != uVar14);
		    }
		    puVar1 = (uint *)func_ii_1080(piVar8,Core_Gameplay_IGame_TypeInfo,0x2e);
		code_r0x81258448:
		    iVar9 = (**(code **)((ulonglong)*puVar1 * 4))(piVar8,puVar1[1]);
		    if (*(longlong *)(*(int *)(iVar9 + 0x10) + 0x10) == 0) {
		      iVar9 = *(int *)(param1 + 8);
		      if (iVar9 != 0) {
		        (**(code **)((ulonglong)*(uint *)(iVar9 + 0xc) * 4))
		                  (*(undefined4 *)(iVar9 + 0x20),param1,*(undefined4 *)(iVar9 + 0x14));
		        return;
		      }
		    }
		    else {
		      uVar14 = 0;
		      piVar8 = *(int **)(param1 + 0x1c);
		      iVar9 = *piVar8;
		      if (*(ushort *)(iVar9 + 0xb6) != 0) {
		        do {
		          if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar9 + 0x58) + uVar14 * 8)) {
		            puVar1 = (uint *)(*(int *)(*(int *)(iVar9 + 0x58) + uVar14 * 8 + 4) * 8 + iVar9 + 0x230)
		            ;
		            goto code_r0x812584f4;
		          }
		          uVar14 = uVar14 + 1;
		        } while (*(ushort *)(iVar9 + 0xb6) != uVar14);
		      }
		      puVar1 = (uint *)func_ii_1080(piVar8,Core_Gameplay_IGame_TypeInfo,0x2e);
		code_r0x812584f4:
		      iVar9 = (**(code **)((ulonglong)*puVar1 * 4))(piVar8,puVar1[1]);
		      piVar8 = *(int **)(param1 + 0x1c);
		      iVar10 = *piVar8;
		      uVar14 = (uint)*(ushort *)(iVar10 + 0xb6);
		      if (*(int *)(*(int *)(iVar9 + 0x10) + 0x20) == 0) {
		        if (uVar14 != 0) {
		          uVar13 = 0;
		          do {
		            if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar10 + 0x58) + uVar13 * 8)) {
		              puVar1 = (uint *)(*(int *)(*(int *)(iVar10 + 0x58) + uVar13 * 8 + 4) * 8 + iVar10 +
		                               0x110);
		              goto code_r0x81258588;
		            }
		            uVar13 = uVar13 + 1;
		          } while (uVar14 != uVar13);
		        }
		        puVar1 = (uint *)func_ii_1080(piVar8,Core_Gameplay_IGame_TypeInfo,10);
		code_r0x81258588:
		        iVar9 = (**(code **)((ulonglong)*puVar1 * 4))(piVar8,puVar1[1]);
		        iVar10 = *(int *)(iVar9 + 0xc);
		        uVar11 = *(undefined4 *)(iVar10 + 0x1c);
		        uVar2 = unnamed_function_1417(System_Action_ulong__TypeInfo);
		        func_ii_6877(uVar2,param1,
		                     Method_Core_Gameplay_Managers_Inventory_GolemInventoryManager_LocationChangedEventHandler__
		                     ,0);
		        iVar9 = UnityEngine_UI_Image__set_sprite(uVar11,uVar2,0);
		        uVar2 = System_Action_ulong__TypeInfo;
		        if (iVar9 == 0) {
		          *(undefined4 *)(iVar10 + 0x1c) = 0;
		        }
		        else {
		          iVar3 = func_ii_1082(iVar9,System_Action_ulong__TypeInfo);
		          if (iVar3 == 0) {
		            System_Activator__CreateInstance(iVar9,uVar2);
		            do {
		              halt_trap();
		            } while( true );
		          }
		          *(int *)(iVar10 + 0x1c) = iVar3;
		          uVar2 = System_Action_ulong__TypeInfo;
		          iVar10 = func_ii_1082(iVar9,System_Action_ulong__TypeInfo);
		          if (iVar10 == 0) {
		            System_Activator__CreateInstance(iVar9,uVar2);
		            do {
		              halt_trap();
		            } while( true );
		          }
		        }
		        iVar9 = *(int *)(param1 + 8);
		        if (iVar9 != 0) {
		          (**(code **)((ulonglong)*(uint *)(iVar9 + 0xc) * 4))
		                    (*(undefined4 *)(iVar9 + 0x20),param1,*(undefined4 *)(iVar9 + 0x14));
		          return;
		        }
		      }
		      else {
		        if (uVar14 != 0) {
		          uVar13 = 0;
		          do {
		            if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar10 + 0x58) + uVar13 * 8)) {
		              puVar1 = (uint *)(*(int *)(*(int *)(iVar10 + 0x58) + uVar13 * 8 + 4) * 8 + iVar10 +
		                               0x140);
		              goto code_r0x8125867d;
		            }
		            uVar13 = uVar13 + 1;
		          } while (uVar14 != uVar13);
		        }
		        puVar1 = (uint *)func_ii_1080(piVar8,Core_Gameplay_IGame_TypeInfo,0x10);
		code_r0x8125867d:
		        uVar14 = 0;
		        uVar2 = (**(code **)((ulonglong)*puVar1 * 4))(piVar8,puVar1[1]);
		        uVar2 = func_ii_7112(uVar2,0);
		        piVar8 = *(int **)(param1 + 0x1c);
		        iVar9 = *piVar8;
		        if (*(ushort *)(iVar9 + 0xb6) != 0) {
		          do {
		            if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar9 + 0x58) + uVar14 * 8)) {
		              puVar1 = (uint *)(*(int *)(*(int *)(iVar9 + 0x58) + uVar14 * 8 + 4) * 8 + iVar9 + 0xe0
		                               );
		              goto code_r0x81258708;
		            }
		            uVar14 = uVar14 + 1;
		          } while (*(ushort *)(iVar9 + 0xb6) != uVar14);
		        }
		        puVar1 = (uint *)func_ii_1080(piVar8,Core_Gameplay_IGame_TypeInfo,4);
		code_r0x81258708:
		        piVar4 = (int *)(**(code **)((ulonglong)*puVar1 * 4))(piVar8,puVar1[1]);
		        uVar14 = 0;
		        iVar9 = *piVar4;
		        if (*(ushort *)(iVar9 + 0xb6) != 0) {
		          do {
		            if (Core_Application_IApp_TypeInfo == *(int *)(*(int *)(iVar9 + 0x58) + uVar14 * 8)) {
		              puVar1 = (uint *)(*(int *)(*(int *)(iVar9 + 0x58) + uVar14 * 8 + 4) * 8 + iVar9 + 0xf0
		                               );
		              goto code_r0x81258788;
		            }
		            uVar14 = uVar14 + 1;
		          } while (*(ushort *)(iVar9 + 0xb6) != uVar14);
		        }
		        puVar1 = (uint *)func_ii_1080(piVar4,Core_Application_IApp_TypeInfo,6);
		code_r0x81258788:
		        uVar14 = 0;
		        uVar11 = (**(code **)((ulonglong)*puVar1 * 4))(piVar4,puVar1[1]);
		        piVar4 = *(int **)(param1 + 0x1c);
		        iVar9 = *piVar4;
		        if (*(ushort *)(iVar9 + 0xb6) != 0) {
		          do {
		            if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar9 + 0x58) + uVar14 * 8)) {
		              puVar1 = (uint *)(*(int *)(*(int *)(iVar9 + 0x58) + uVar14 * 8 + 4) * 8 + iVar9 +
		                               0x158);
		              goto code_r0x8125880d;
		            }
		            uVar14 = uVar14 + 1;
		          } while (*(ushort *)(iVar9 + 0xb6) != uVar14);
		        }
		        puVar1 = (uint *)func_ii_1080(piVar4,Core_Gameplay_IGame_TypeInfo,0x13);
		code_r0x8125880d:
		        uVar14 = 0;
		        uVar5 = (**(code **)((ulonglong)*puVar1 * 4))(piVar4,puVar1[1]);
		        uVar5 = Core_Gameplay_Managers_CacheManager__GetEndOfFrameCacheRequestAccumulator(uVar5,0);
		        piVar4 = *(int **)(param1 + 0x1c);
		        iVar9 = *piVar4;
		        if (*(ushort *)(iVar9 + 0xb6) != 0) {
		          do {
		            if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar9 + 0x58) + uVar14 * 8)) {
		              puVar1 = (uint *)(*(int *)(*(int *)(iVar9 + 0x58) + uVar14 * 8 + 4) * 8 + iVar9 +
		                               0x160);
		              goto code_r0x81258898;
		            }
		            uVar14 = uVar14 + 1;
		          } while (*(ushort *)(iVar9 + 0xb6) != uVar14);
		        }
		        puVar1 = (uint *)func_ii_1080(piVar4,Core_Gameplay_IGame_TypeInfo,0x14);
		code_r0x81258898:
		        uVar14 = 0;
		        uVar6 = (**(code **)((ulonglong)*puVar1 * 4))(piVar4,puVar1[1]);
		        piVar4 = *(int **)(param1 + 0x1c);
		        iVar9 = *piVar4;
		        if (*(ushort *)(iVar9 + 0xb6) != 0) {
		          do {
		            if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar9 + 0x58) + uVar14 * 8)) {
		              puVar1 = (uint *)(*(int *)(*(int *)(iVar9 + 0x58) + uVar14 * 8 + 4) * 8 + iVar9 +
		                               0x178);
		              goto code_r0x8125891d;
		            }
		            uVar14 = uVar14 + 1;
		          } while (*(ushort *)(iVar9 + 0xb6) != uVar14);
		        }
		        puVar1 = (uint *)func_ii_1080(piVar4,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x8125891d:
		        uVar14 = 0;
		        uVar7 = (**(code **)((ulonglong)*puVar1 * 4))(piVar4,puVar1[1]);
		        piVar4 = *(int **)(param1 + 0x1c);
		        iVar9 = *piVar4;
		        if (*(ushort *)(iVar9 + 0xb6) != 0) {
		          do {
		            if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar9 + 0x58) + uVar14 * 8)) {
		              puVar1 = (uint *)(*(int *)(*(int *)(iVar9 + 0x58) + uVar14 * 8 + 4) * 8 + iVar9 +
		                               0x230);
		              goto code_r0x812589a2;
		            }
		            uVar14 = uVar14 + 1;
		          } while (*(ushort *)(iVar9 + 0xb6) != uVar14);
		        }
		        puVar1 = (uint *)func_ii_1080(piVar4,Core_Gameplay_IGame_TypeInfo,0x2e);
		code_r0x812589a2:
		        iVar9 = (**(code **)((ulonglong)*puVar1 * 4))(piVar4,puVar1[1]);
		        uVar12 = *(undefined4 *)(*(int *)(iVar9 + 0x10) + 0x20);
		        iVar9 = unnamed_function_1417
		                          (Gameplay_Clans_Buildings_Golem_Model_GolemInventoryModel_TypeInfo);
		        Gameplay_Clans_Buildings_Golem_Model_GolemInventoryModel__get_OwnerUser
		                  (iVar9,piVar8,uVar11,uVar5,uVar6,uVar7,uVar2,uVar12,0);
		        *(int *)(param1 + 0x10) = iVar9;
		        uVar11 = *(undefined4 *)(param1 + 0x18);
		        uVar5 = *(undefined4 *)(iVar9 + 0x58);
		        uVar2 = unnamed_function_1417
		                          (
		                          Gameplay_Clans_Buildings_Golem_Controller_Middlewares_GolemInventoryActionsMiddleware_TypeInfo
		                          );
		        Gameplay_Clans_Buildings_Golem_Controller_WarStatusViewMasterMediator__Dispose
		                  (uVar2,iVar9,uVar5,0);
		        if (*(int *)(Core_Net_ServiceFactory_TypeInfo + 0x74) == 0) {
		          func_ii_306000(Core_Net_ServiceFactory_TypeInfo);
		        }
		        uVar5 = Core_Gameplay_Managers_LoggedManager__RequestLogin
		                          (Method_Core_Net_ServiceFactory_GetService_ClansService___);
		        uVar6 = Core_Gameplay_Managers_LoggedManager__RequestLogin
		                          (Method_Core_Net_ServiceFactory_GetService_ServicesService___);
		        uVar7 = Core_Gameplay_Managers_LoggedManager__RequestLogin
		                          (Method_Core_Net_ServiceFactory_GetService_CraftService___);
		        uVar12 = unnamed_function_1417
		                           (
		                           Gameplay_Clans_Buildings_Golem_Controller_GolemInventoryController_TypeInfo
		                           );
		        Gameplay_Clans_Buildings_Golem_Controller_GolemInfoViewMediator___c__DisplayClass9_0___EquipmentViewOnSlotClickedEventHandler_b__0
		                  (uVar12,iVar9,uVar11,uVar2,uVar5,uVar6,uVar7,0);
		        *(undefined4 *)(param1 + 0x14) = uVar12;
		        uVar11 = *(undefined4 *)(param1 + 0x18);
		        uVar2 = unnamed_function_1417
		                          (Gameplay_ArtifactComparer_Controller_ArtifactComparerEvents_TypeInfo);
		        UnityEngine_Purchasing_Default_WinProductDescription__set_title(uVar2,uVar11,0);
		        *(undefined4 *)(param1 + 0x28) = uVar2;
		        iVar9 = *(int *)(param1 + 0x10);
		        uVar11 = *(undefined4 *)(iVar9 + 0x58);
		        uVar2 = unnamed_function_1417
		                          (Gameplay_ArtifactComparer_Model_ArtifactComparerModel_TypeInfo);
		        Gameplay_ArtifactComparer_Model_ArtifactComparerModel__set_EnabledSkillIds
		                  (uVar2,uVar11,iVar9,0);
		        *(undefined4 *)(param1 + 0x20) = uVar2;
		        uVar5 = *(undefined4 *)(param1 + 0x28);
		        uVar11 = unnamed_function_1417
		                           (Gameplay_ArtifactComparer_Controller_ArtifactComparerController_TypeInfo
		                           );
		        Gameplay_ArtifactComparer_Model_ComparerValueRow___ctor(uVar11,uVar2,uVar5,0);
		        *(undefined4 *)(param1 + 0x24) = uVar11;
		        MVC_AbstractController__Dispose(uVar11,0);
		        iVar10 = *(int *)(param1 + 0x18);
		        uVar11 = *(undefined4 *)(iVar10 + 8);
		        uVar2 = unnamed_function_1417(System_Action_TypeInfo);
		        UnityEngine_Events_UnityEvent__AddListener
		                  (uVar2,param1,
		                   Method_Core_Gameplay_Managers_Inventory_GolemInventoryManager_ControllerInitEventHandler__
		                   ,0);
		        piVar8 = (int *)UnityEngine_UI_Image__set_sprite(uVar11,uVar2,0);
		        iVar9 = System_Action_TypeInfo;
		        if (piVar8 == (int *)0x0) {
		          *(undefined4 *)(iVar10 + 8) = 0;
		        }
		        else if ((System_Action_TypeInfo != *piVar8) ||
		                (*(int **)(iVar10 + 8) = piVar8, *piVar8 != iVar9)) {
		          System_Activator__CreateInstance(piVar8,iVar9);
		          do {
		            halt_trap();
		          } while( true );
		        }
		        MVC_AbstractController__Dispose(*(undefined4 *)(param1 + 0x14),0);
		      }
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x06006C19 RID: 27673 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006C19")]
		[Address(RVA = "0xB708", Offset = "0xB708", VA = "0xB708", Slot = "8")]
		public void Init()
		{
		/* --- GHIDRA: Init ---
		void Core_Gameplay_Managers_Inventory_GolemInventoryManager__Init
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4,undefined4 param5)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 param1_00;
		  int *piVar3;
		  int iVar4;
		  
		  if (DAT_ram_00a5a6c4 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Application_IApp_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Inventory_View_Chest_InventoryChestWindowOptions_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Windows_PopupController_Show_GolemInventoryChestWindow___);
		    Mono_Security_ASN1__get_Item(&StringLiteral_12592);
		    DAT_ram_00a5a6c4 = '\x01';
		  }
		  piVar3 = *(int **)(param1 + 0x1c);
		  iVar4 = *piVar3;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0xe0);
		        goto code_r0x8125914f;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar3,Core_Gameplay_IGame_TypeInfo,4);
		code_r0x8125914f:
		  piVar3 = (int *)(**(code **)((ulonglong)*puVar2 * 4))(piVar3,puVar2[1]);
		  uVar1 = 0;
		  iVar4 = *piVar3;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (Core_Application_IApp_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0xe8);
		        goto code_r0x812591d1;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar3,Core_Application_IApp_TypeInfo,5);
		code_r0x812591d1:
		  param1_00 = (**(code **)((ulonglong)*puVar2 * 4))(piVar3,puVar2[1]);
		  iVar4 = unnamed_function_1417(Gameplay_Inventory_View_Chest_InventoryChestWindowOptions_TypeInfo);
		  Gameplay_AccountLinker_View_SelectUserWindow___ctor(iVar4,0);
		  *(undefined4 *)(iVar4 + 0x20) = param4;
		  *(undefined4 *)(iVar4 + 0x1c) = param3;
		  *(undefined4 *)(iVar4 + 0x18) = param2;
		  Gameplay_Antiq_View_GroupReviewWindow_WindowArgs___ctor
		            (param1_00,StringLiteral_12592,iVar4,
		             Method_UI_Windows_PopupController_Show_GolemInventoryChestWindow___);
		  return;
		}
		*/

		}

		// Token: 0x06006C1A RID: 27674 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006C1A")]
		[Address(RVA = "0xB709", Offset = "0xB709", VA = "0xB709")]
		public void ShowChestWindow([Optional] ArtikulMenuActionDic.Types.Actions[] customActions, [Optional] ArtikulMenuActionDic.Types.Actions[] closeWindowActions, [Optional] InventoryChestWindowOptions.ArtifactFilterDelegate customFilterFunction)
		{
		/* --- GHIDRA: ShowChestWindow ---
		void Core_Gameplay_Managers_Inventory_GolemInventoryManager__ShowChestWindow
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  uint uVar1;
		  int param1_00;
		  uint *puVar2;
		  undefined4 uVar3;
		  int *piVar4;
		  int iVar5;
		  
		  if (DAT_ram_00a5a6c5 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_ArtifactComparer_View_ArtifactComparerWindow_ArtifactComparerWindowArgs_TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&Core_Application_IApp_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Windows_PopupController_GetWindows_ArtifactComparerWindow___);
		    Mono_Security_ASN1__get_Item(&Method_UI_Windows_PopupController_Show_ArtifactComparerWindow___);
		    Mono_Security_ASN1__get_Item(&StringLiteral_12633);
		    DAT_ram_00a5a6c5 = '\x01';
		  }
		  param1_00 = unnamed_function_1417
		                        (
		                        Gameplay_ArtifactComparer_View_ArtifactComparerWindow_ArtifactComparerWindowArgs_TypeInfo
		                        );
		  Gameplay_AccountLinker_View_SelectUserWindow___ctor(param1_00,0);
		  *(undefined4 *)(param1_00 + 0x18) = param2;
		  *(undefined4 *)(param1_00 + 0x20) = *(undefined4 *)(param1 + 0x24);
		  *(undefined4 *)(param1_00 + 0x1c) = *(undefined4 *)(param1 + 0x28);
		  uVar3 = *(undefined4 *)(param1 + 0x20);
		  *(undefined1 *)(param1_00 + 0x28) = 1;
		  *(undefined4 *)(param1_00 + 0x24) = uVar3;
		  piVar4 = *(int **)(param1 + 0x1c);
		  iVar5 = *piVar4;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0xe0);
		        goto code_r0x81259322;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar4,Core_Gameplay_IGame_TypeInfo,4);
		code_r0x81259322:
		  piVar4 = (int *)(**(code **)((ulonglong)*puVar2 * 4))(piVar4,puVar2[1]);
		  uVar1 = 0;
		  iVar5 = *piVar4;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    do {
		      if (Core_Application_IApp_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0xe8);
		        goto code_r0x812593a6;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar4,Core_Application_IApp_TypeInfo,5);
		code_r0x812593a6:
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(piVar4,puVar2[1]);
		  iVar5 = UI_Windows_PopupController__GetLastWindow_object_
		                    (uVar3,Method_UI_Windows_PopupController_GetWindows_ArtifactComparerWindow___);
		  if ((iVar5 != 0) && (*(int *)(iVar5 + 0xc) != 0)) {
		    Gameplay_ArtifactComparer_View_ArtifactComparerWindow__InitMvc
		              (*(undefined4 *)(iVar5 + 0x10),param1_00,0);
		    return;
		  }
		  piVar4 = *(int **)(param1 + 0x1c);
		  iVar5 = *piVar4;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0xe0);
		        goto code_r0x8125944d;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar4,Core_Gameplay_IGame_TypeInfo,4);
		code_r0x8125944d:
		  piVar4 = (int *)(**(code **)((ulonglong)*puVar2 * 4))(piVar4,puVar2[1]);
		  uVar1 = 0;
		  iVar5 = *piVar4;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    do {
		      if (Core_Application_IApp_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0xe8);
		        goto code_r0x812594cf;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar4,Core_Application_IApp_TypeInfo,5);
		code_r0x812594cf:
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(piVar4,puVar2[1]);
		  Gameplay_Antiq_View_GroupReviewWindow_WindowArgs___ctor
		            (uVar3,StringLiteral_12633,param1_00,
		             Method_UI_Windows_PopupController_Show_ArtifactComparerWindow___);
		  return;
		}
		*/

		}

		// Token: 0x06006C1B RID: 27675 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006C1B")]
		[Address(RVA = "0xB70A", Offset = "0xB70A", VA = "0xB70A")]
		public void ShowArtifactComparerWindow(ArtifactData artifactData)
		{
		/* --- GHIDRA: ShowArtifactComparerWindow ---
		void Core_Gameplay_Managers_Inventory_GolemInventoryManager__ShowArtifactComparerWindow
		               (undefined4 param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int *param3_00;
		  int iVar2;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a5a6c6 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ArtifactData____TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Data_ArtifactData___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Gameplay_Managers_Inventory_GolemInventoryManager__SellItem_b__44_0__);
		    DAT_ram_00a5a6c6 = '\x01';
		  }
		  param1_00 = *(undefined4 *)(param2 + 0x70);
		  uVar1 = unnamed_function_1417(System_Action_ArtifactData____TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar1,param1,
		             Method_Core_Gameplay_Managers_Inventory_GolemInventoryManager__SellItem_b__44_0__,0);
		  param3_00 = (int *)Mono_Security_ASN1Convert__ToOid(Core_Data_ArtifactData___TypeInfo,1);
		  iVar2 = func_ii_1082(param2,*(undefined4 *)(*param3_00 + 0x20));
		  if (iVar2 == 0) {
		    uVar1 = func_ii_1083();
		    func_ii_1050(uVar1,0);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  param3_00[4] = param2;
		  Gameplay_Clans_Buildings_MagicTower_Controller_MagicTowerViewMediator___c__DisplayClass21_0___ShowAccelerateImroveSpell_b__0
		            (param1_00,uVar1,param3_00,0);
		  return;
		}
		*/

		}

		// Token: 0x06006C1C RID: 27676 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006C1C")]
		[Address(RVA = "0xB70B", Offset = "0xB70B", VA = "0xB70B")]
		public void SellItem(ArtifactData artifactData)
		{
		}

		// Token: 0x040038E5 RID: 14565
		[Token(Token = "0x40038E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private readonly IGame _game;

		// Token: 0x040038E6 RID: 14566
		[Token(Token = "0x40038E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private ArtifactComparerModel _comparerModel;

		// Token: 0x040038E7 RID: 14567
		[Token(Token = "0x40038E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private ArtifactComparerController _comparerController;

		// Token: 0x040038E8 RID: 14568
		[Token(Token = "0x40038E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private ArtifactComparerEvents _comparerEvents;

		// Token: 0x040038E9 RID: 14569
		[Token(Token = "0x40038E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private ClanIsleEvents _clanIsleEvents;

		// Token: 0x040038EA RID: 14570
		[Token(Token = "0x40038EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private ClanIsle _clanIsle;

		// Token: 0x040038EB RID: 14571
		[Token(Token = "0x40038EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private bool _isInit;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_Name ---
		void Core_Gameplay_Managers_Inventory_GolemInventoryManager__get_Name
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5a6b6 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a5a6b6 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 8);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_IBaseManager__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_IBaseManager__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 8,iVar2,param1_00);
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


		/* --- GHIDRA: add_InitCompleteEvent ---
		void Core_Gameplay_Managers_Inventory_GolemInventoryManager__add_InitCompleteEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5a6b7 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a5a6b7 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 8);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_IBaseManager__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_IBaseManager__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 8,iVar2,param1_00);
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


		/* --- GHIDRA: remove_InitCompleteEvent ---
		void Core_Gameplay_Managers_Inventory_GolemInventoryManager__remove_InitCompleteEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5a6b8 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a5a6b8 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0xc);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_IBaseManager__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_IBaseManager__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0xc,iVar2,param1_00);
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


		/* --- GHIDRA: add_DeinitCompleteEvent ---
		void Core_Gameplay_Managers_Inventory_GolemInventoryManager__add_DeinitCompleteEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5a6b9 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a5a6b9 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0xc);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_IBaseManager__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_IBaseManager__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0xc,iVar2,param1_00);
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


		/* --- GHIDRA: Core.Gameplay.Managers.Inventory.IInventoryManager.get_Events ---
		void Core_Gameplay_Managers_Inventory_GolemInventoryManager__Core_Gameplay_Managers_Inventory_IInventoryManager_get_Events
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a5a6ba == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Clans_Buildings_Golem_Events_GolemInventoryEvents_TypeInfo);
		    DAT_ram_00a5a6ba = '\x01';
		  }
		  uVar1 = unnamed_function_1417(Gameplay_Clans_Buildings_Golem_Events_GolemInventoryEvents_TypeInfo)
		  ;
		  *(undefined4 *)(param1 + 0x18) = uVar1;
		  *(undefined4 *)(param1 + 0x1c) = param2;
		  return;
		}
		*/


		/* --- GHIDRA: set_ClanIsle ---
		void Core_Gameplay_Managers_Inventory_GolemInventoryManager__set_ClanIsle
		               (int param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int iVar3;
		  int iVar4;
		  undefined4 uVar5;
		  
		  if (DAT_ram_00a5a6bc == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_uint__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Gameplay_Managers_Inventory_GolemInventoryManager_BuildingStateChangedEventHandler__
		              );
		    DAT_ram_00a5a6bc = '\x01';
		  }
		  iVar4 = *(int *)(param1 + 0x2c);
		  if (iVar4 != 0) {
		    uVar5 = *(undefined4 *)(iVar4 + 0x14);
		    uVar2 = unnamed_function_1417(System_Action_uint__TypeInfo);
		    func_ii_12322(uVar2,param1,
		                  Method_Core_Gameplay_Managers_Inventory_GolemInventoryManager_BuildingStateChangedEventHandler__
		                  ,0);
		    iVar3 = func_ii_7048(uVar5,uVar2,0);
		    uVar2 = System_Action_uint__TypeInfo;
		    if (iVar3 == 0) {
		      *(undefined4 *)(iVar4 + 0x14) = 0;
		    }
		    else {
		      iVar1 = func_ii_1082(iVar3,System_Action_uint__TypeInfo);
		      if (iVar1 == 0) {
		        System_Activator__CreateInstance(iVar3,uVar2);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      *(int *)(iVar4 + 0x14) = iVar1;
		      uVar2 = System_Action_uint__TypeInfo;
		      iVar4 = func_ii_1082(iVar3,System_Action_uint__TypeInfo);
		      if (iVar4 == 0) {
		        System_Activator__CreateInstance(iVar3,uVar2);
		        do {
		          halt_trap();
		        } while( true );
		      }
		    }
		  }
		  *(int *)(param1 + 0x2c) = param2;
		  if (param2 != 0) {
		    uVar5 = *(undefined4 *)(param2 + 0x14);
		    uVar2 = unnamed_function_1417(System_Action_uint__TypeInfo);
		    func_ii_12322(uVar2,param1,
		                  Method_Core_Gameplay_Managers_Inventory_GolemInventoryManager_BuildingStateChangedEventHandler__
		                  ,0);
		    iVar4 = UnityEngine_UI_Image__set_sprite(uVar5,uVar2,0);
		    uVar2 = System_Action_uint__TypeInfo;
		    if (iVar4 == 0) {
		      *(undefined4 *)(param2 + 0x14) = 0;
		      return;
		    }
		    iVar3 = func_ii_1082(iVar4,System_Action_uint__TypeInfo);
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(iVar4,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(param2 + 0x14) = iVar3;
		    uVar2 = System_Action_uint__TypeInfo;
		    iVar3 = func_ii_1082(iVar4,System_Action_uint__TypeInfo);
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(iVar4,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  return;
		}
		*/


		/* --- GHIDRA: set_ClanIsleEvents ---
		void Core_Gameplay_Managers_Inventory_GolemInventoryManager__set_ClanIsleEvents
		               (int param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined1 auStack_10 [12];
		  undefined4 local_4;
		  
		  if (DAT_ram_00a5a6bd == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Isles_Base_AbstractIsle_ClanIsleEvents__ClanIsleModel__ClanIsleController__ClanBuildingTypes__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__BaseBuildingData__TryGetValue__);
		    DAT_ram_00a5a6bd = '\x01';
		  }
		  local_4 = 0;
		  if (((param2 == 1) &&
		      (iVar1 = UnityEngine_TextCore_LowLevel_LigatureSubstitutionRecord__get_componentGlyphIDs
		                         (*(undefined4 *)(*(int *)(*(int *)(param1 + 0x30) + 0x10) + 0x24),1,
		                          &local_4,
		                          Method_System_Collections_Generic_Dictionary_uint__BaseBuildingData__TryGetValue__
		                         ), iVar1 != 0)) &&
		     (iVar1 = Newtonsoft_Json_Converters_XDeclarationWrapper__get_Encoding(local_4,0), iVar1 != 0))
		  {
		    Core_Gameplay_Managers_Inventory_GolemInventoryManager__BuildingStateChangedEventHandler
		              (param1,auStack_10);
		  }
		  return;
		}
		*/

}
