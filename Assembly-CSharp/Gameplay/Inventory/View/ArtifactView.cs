using System;
using System.Runtime.CompilerServices;
using Core;
using Core.Data;
using Gameplay.Tutorial.Guide.Model.Data;
using Il2CppDummyDll;
using Protocol;
using Protocol.Dic;
using UI;
using UI.ToolTip;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using Utils;

namespace Gameplay.Inventory.View
{
	// Token: 0x02000657 RID: 1623
	[Token(Token = "0x2000657")]
	public class ArtifactView : AbstractDataRenderer<ArtifactData>, IArtifactView, IPointerEnterHandler, IEventSystemHandler, IToolTipDataProvider, IPointerClickHandler
	{
		// Token: 0x1700076B RID: 1899
		// (get) Token: 0x06002754 RID: 10068 RVA: 0x00007890 File Offset: 0x00005A90
		// (set) Token: 0x06002755 RID: 10069 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700076B")]
		public InteractiveBehavior Mode
		{
			[Token(Token = "0x6002754")]
			[Address(RVA = "0x7887", Offset = "0x7887", VA = "0x7887")]
			get
			{
				return InteractiveBehavior.Default;
			}
			[Token(Token = "0x6002755")]
			[Address(RVA = "0x7888", Offset = "0x7888", VA = "0x7888")]
			set
			{
			}
		}

		// Token: 0x06002756 RID: 10070 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002756")]
		[Address(RVA = "0x7889", Offset = "0x7889", VA = "0x7889", Slot = "9")]
		protected override void Awake()
		{
		/* --- GHIDRA: Awake ---
		void Gameplay_Inventory_View_ArtifactView__Awake(int *param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a5a085 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UI_AbstractDataRenderer_ArtifactData__Dispose__);
		    DAT_ram_00a5a085 = '\x01';
		  }
		  UI_AbstractDataRenderer_object___CommitProperties
		            (param1,Method_UI_AbstractDataRenderer_ArtifactData__Dispose__);
		  (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		            (param1,0,*(undefined4 *)(*param1 + 0x13c));
		  return;
		}
		*/

		}

		// Token: 0x06002757 RID: 10071 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002757")]
		[Address(RVA = "0x788A", Offset = "0x788A", VA = "0x788A", Slot = "10")]
		public override void Dispose()
		{
		/* --- GHIDRA: Dispose ---
		void Gameplay_Inventory_View_ArtifactView__Dispose
		               (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a5a086 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Inventory_View_ArtifactView_ArtifactDataOnArtifactInfoChangedEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Inventory_View_ArtifactView_ArtifactDataOnIsFavoriteChangedEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Inventory_View_ArtifactView_ArtifactDataOnIsFreshChangedEvent__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Inventory_View_ArtifactView_ArtifactDataOnIsFreshWatchedChangedEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Inventory_View_ArtifactView_ArtifactDataOnIsMostPowerfulChangedEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Inventory_View_ArtifactView_ArtifactDataOnSlotIdChangedEvent__);
		    DAT_ram_00a5a086 = '\x01';
		  }
		  uVar1 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar1,param1,
		             Method_Gameplay_Inventory_View_ArtifactView_ArtifactDataOnIsFavoriteChangedEvent__,0);
		  Core_Dev_LaunchLevelPlayTestSuite___ctor(param2,uVar1,0);
		  uVar1 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar1,param1,
		             Method_Gameplay_Inventory_View_ArtifactView_ArtifactDataOnIsFreshChangedEvent__,0);
		  Core_Data_ArtifactData__remove_IsFavoriteChangedEvent(param2,uVar1,0);
		  uVar1 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar1,param1,
		             Method_Gameplay_Inventory_View_ArtifactView_ArtifactDataOnIsFreshWatchedChangedEvent__,
		             0);
		  Core_Data_ArtifactData__remove_IsFreshChangedEvent(param2,uVar1,0);
		  uVar1 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar1,param1,
		             Method_Gameplay_Inventory_View_ArtifactView_ArtifactDataOnArtifactInfoChangedEvent__,0)
		  ;
		  Core_Data_ArtifactData__remove_IsFreshWatchedChangedEvent(param2,uVar1,0);
		  uVar1 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar1,param1,
		             Method_Gameplay_Inventory_View_ArtifactView_ArtifactDataOnIsMostPowerfulChangedEvent__,
		             0);
		  Core_Data_ArtifactData__remove_ArtifactInfoChangedEvent(param2,uVar1,0);
		  uVar1 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar1,param1,
		             Method_Gameplay_Inventory_View_ArtifactView_ArtifactDataOnSlotIdChangedEvent__,0);
		  Core_Data_ArtifactData__remove_IsMostPowerfulChangedEvent(param2,uVar1,0);
		  return;
		}
		*/

		}

		// Token: 0x06002758 RID: 10072 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002758")]
		[Address(RVA = "0x788B", Offset = "0x788B", VA = "0x788B", Slot = "17")]
		protected override void StartListenEvents(ArtifactData data)
		{
		/* --- GHIDRA: StartListenEvents ---
		void Gameplay_Inventory_View_ArtifactView__StartListenEvents(int param1,undefined4 param2)
		
		{
		  *(undefined1 *)(param1 + 0x45) = 1;
		  UI_AbstractDeferredRenderer__KillCoroutine(param1,0);
		  return;
		}
		*/

		}

		// Token: 0x06002759 RID: 10073 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002759")]
		[Address(RVA = "0x788C", Offset = "0x788C", VA = "0x788C")]
		private void ArtifactDataOnSlotIdChangedEvent()
		{
		/* --- GHIDRA: ArtifactDataOnSlotIdChangedEvent ---
		void Gameplay_Inventory_View_ArtifactView__ArtifactDataOnSlotIdChangedEvent
		               (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a5a087 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Inventory_View_ArtifactView_ArtifactDataOnArtifactInfoChangedEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Inventory_View_ArtifactView_ArtifactDataOnIsFavoriteChangedEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Inventory_View_ArtifactView_ArtifactDataOnIsFreshChangedEvent__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Inventory_View_ArtifactView_ArtifactDataOnIsFreshWatchedChangedEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Inventory_View_ArtifactView_ArtifactDataOnIsMostPowerfulChangedEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Inventory_View_ArtifactView_ArtifactDataOnSlotIdChangedEvent__);
		    DAT_ram_00a5a087 = '\x01';
		  }
		  uVar1 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar1,param1,
		             Method_Gameplay_Inventory_View_ArtifactView_ArtifactDataOnIsFavoriteChangedEvent__,0);
		  Core_Data_ArtifactData__add_IsFavoriteChangedEvent(param2,uVar1,0);
		  uVar1 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar1,param1,
		             Method_Gameplay_Inventory_View_ArtifactView_ArtifactDataOnIsFreshChangedEvent__,0);
		  Core_Data_ArtifactData__add_IsFreshChangedEvent(param2,uVar1,0);
		  uVar1 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar1,param1,
		             Method_Gameplay_Inventory_View_ArtifactView_ArtifactDataOnIsFreshWatchedChangedEvent__,
		             0);
		  Core_Data_ArtifactData__add_IsFreshWatchedChangedEvent(param2,uVar1,0);
		  uVar1 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar1,param1,
		             Method_Gameplay_Inventory_View_ArtifactView_ArtifactDataOnArtifactInfoChangedEvent__,0)
		  ;
		  Core_Data_ArtifactData__add_ArtifactInfoChangedEvent(param2,uVar1,0);
		  uVar1 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar1,param1,
		             Method_Gameplay_Inventory_View_ArtifactView_ArtifactDataOnIsMostPowerfulChangedEvent__,
		             0);
		  Core_Data_ArtifactData__add_IsMostPowerfulChangedEvent(param2,uVar1,0);
		  uVar1 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar1,param1,
		             Method_Gameplay_Inventory_View_ArtifactView_ArtifactDataOnSlotIdChangedEvent__,0);
		  Core_Data_ArtifactData__add_SlotIdChangedEvent(param2,uVar1,0);
		  return;
		}
		*/

		}

		// Token: 0x0600275A RID: 10074 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600275A")]
		[Address(RVA = "0x788D", Offset = "0x788D", VA = "0x788D", Slot = "18")]
		protected override void StopListenEvents(ArtifactData data)
		{
		/* --- GHIDRA: StopListenEvents ---
		int Gameplay_Inventory_View_ArtifactView__StopListenEvents(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a5a088 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Component_GetComponent_IGuideTarget___);
		    DAT_ram_00a5a088 = '\x01';
		  }
		  iVar1 = *(int *)(param1 + 0x48);
		  if (iVar1 == 0) {
		    iVar1 = func_ii_5677(param1,Method_UnityEngine_Component_GetComponent_IGuideTarget___);
		  }
		  *(int *)(param1 + 0x48) = iVar1;
		  return iVar1;
		}
		*/

		}

		// Token: 0x1700076C RID: 1900
		// (get) Token: 0x0600275B RID: 10075 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700076C")]
		public IGuideTarget GuideTarget
		{
			[Token(Token = "0x600275B")]
			[Address(RVA = "0x788E", Offset = "0x788E", VA = "0x788E")]
			get
			{
				return null;
			}
		}

		// Token: 0x14000151 RID: 337
		// (add) Token: 0x0600275C RID: 10076 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600275D RID: 10077 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000151")]
		public event Action<ArtifactView> ClickEvent
		{
			[Token(Token = "0x600275C")]
			[Address(RVA = "0x1D8E", Offset = "0x1D8E", VA = "0x1D8E")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600275D")]
			[Address(RVA = "0x788F", Offset = "0x788F", VA = "0x788F")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x0600275E RID: 10078 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600275E")]
		[Address(RVA = "0x7890", Offset = "0x7890", VA = "0x7890", Slot = "16")]
		protected override void OnDataInvalidated()
		{
		/* --- GHIDRA: OnDataInvalidated ---
		void Gameplay_Inventory_View_ArtifactView__OnDataInvalidated
		               (undefined8 *param1,int param2,undefined4 param3)
		
		{
		  *param1 = *(undefined8 *)(param2 + 0x50);
		  *(undefined4 *)(param1 + 1) = *(undefined4 *)(param2 + 0x58);
		  return;
		}
		*/

		}

		// Token: 0x1700076D RID: 1901
		// (get) Token: 0x0600275F RID: 10079 RVA: 0x000078A8 File Offset: 0x00005AA8
		// (set) Token: 0x06002760 RID: 10080 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700076D")]
		public ArtifactView.ArtifactViewArgs Args
		{
			[Token(Token = "0x600275F")]
			[Address(RVA = "0x7891", Offset = "0x7891", VA = "0x7891", Slot = "23")]
			get
			{
				return default(ArtifactView.ArtifactViewArgs);
			}
			[Token(Token = "0x6002760")]
			[Address(RVA = "0x1D8D", Offset = "0x1D8D", VA = "0x1D8D", Slot = "24")]
			set
			{
			}
		}

		// Token: 0x06002761 RID: 10081 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002761")]
		[Address(RVA = "0x7892", Offset = "0x7892", VA = "0x7892")]
		private void ArtifactDataOnIsMostPowerfulChangedEvent()
		{
		/* --- GHIDRA: ArtifactDataOnIsMostPowerfulChangedEvent ---
		void Gameplay_Inventory_View_ArtifactView__ArtifactDataOnIsMostPowerfulChangedEvent
		               (int param1,undefined4 param2)
		
		{
		  *(undefined1 *)(param1 + 0x41) = 1;
		  *(undefined1 *)(param1 + 0x44) = 1;
		  UI_AbstractDeferredRenderer__KillCoroutine(param1,0);
		  return;
		}
		*/

		}

		// Token: 0x06002762 RID: 10082 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002762")]
		[Address(RVA = "0x7893", Offset = "0x7893", VA = "0x7893")]
		private void ArtifactDataOnArtifactInfoChangedEvent()
		{
		}

		// Token: 0x06002763 RID: 10083 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002763")]
		[Address(RVA = "0x7894", Offset = "0x7894", VA = "0x7894")]
		private void ArtifactDataOnIsFreshWatchedChangedEvent()
		{
		/* --- GHIDRA: ArtifactDataOnIsFreshWatchedChangedEvent ---
		void Gameplay_Inventory_View_ArtifactView__ArtifactDataOnIsFreshWatchedChangedEvent
		               (int param1,undefined4 param2)
		
		{
		  *(undefined1 *)(param1 + 0x43) = 1;
		  UI_AbstractDeferredRenderer__KillCoroutine(param1,0);
		  return;
		}
		*/

		}

		// Token: 0x06002764 RID: 10084 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002764")]
		[Address(RVA = "0x7895", Offset = "0x7895", VA = "0x7895")]
		private void ArtifactDataOnIsFreshChangedEvent()
		{
		/* --- GHIDRA: ArtifactDataOnIsFreshChangedEvent ---
		void Gameplay_Inventory_View_ArtifactView__ArtifactDataOnIsFreshChangedEvent
		               (int param1,undefined4 param2)
		
		{
		  *(undefined1 *)(param1 + 0x42) = 1;
		  UI_AbstractDeferredRenderer__KillCoroutine(param1,0);
		  return;
		}
		*/

		}

		// Token: 0x06002765 RID: 10085 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002765")]
		[Address(RVA = "0x7896", Offset = "0x7896", VA = "0x7896")]
		private void ArtifactDataOnIsFavoriteChangedEvent()
		{
		/* --- GHIDRA: ArtifactDataOnIsFavoriteChangedEvent ---
		void Gameplay_Inventory_View_ArtifactView__ArtifactDataOnIsFavoriteChangedEvent
		               (int *param1,undefined4 param2)
		
		{
		  uint uVar1;
		  int iVar2;
		  undefined4 uVar3;
		  uint *puVar4;
		  undefined4 uVar5;
		  int *piVar6;
		  
		  if (DAT_ram_00a5a08c == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Tutorial_Guide_Model_Data_IGuideTarget_TypeInfo);
		    DAT_ram_00a5a08c = '\x01';
		  }
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x130) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x134));
		  piVar6 = (int *)param1[10];
		  if (iVar2 == 0) {
		    (**(code **)((ulonglong)*(uint *)(*piVar6 + 0x138) * 4))
		              (piVar6,0,*(undefined4 *)(*piVar6 + 0x13c));
		    return;
		  }
		  uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x130) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x134));
		  (**(code **)((ulonglong)*(uint *)(*piVar6 + 0x138) * 4))
		            (piVar6,uVar3,*(undefined4 *)(*piVar6 + 0x13c));
		  if (DAT_ram_00a5a088 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Component_GetComponent_IGuideTarget___);
		    DAT_ram_00a5a088 = '\x01';
		  }
		  piVar6 = (int *)param1[0x12];
		  if (piVar6 == (int *)0x0) {
		    piVar6 = (int *)func_ii_5677(param1,Method_UnityEngine_Component_GetComponent_IGuideTarget___);
		  }
		  param1[0x12] = (int)piVar6;
		  uVar1 = 0;
		  iVar2 = *piVar6;
		  if (*(ushort *)(iVar2 + 0xb6) != 0) {
		    do {
		      if (Gameplay_Tutorial_Guide_Model_Data_IGuideTarget_TypeInfo ==
		          *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 0xe0);
		        goto code_r0x811c0747;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(piVar6,Gameplay_Tutorial_Guide_Model_Data_IGuideTarget_TypeInfo,4);
		code_r0x811c0747:
		  uVar3 = (**(code **)((ulonglong)*puVar4 * 4))(piVar6,puVar4[1]);
		  uVar5 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x130) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x134));
		  if (DAT_ram_00a5a088 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Component_GetComponent_IGuideTarget___);
		    DAT_ram_00a5a088 = '\x01';
		  }
		  iVar2 = param1[0x12];
		  if (iVar2 == 0) {
		    iVar2 = func_ii_5677(param1,Method_UnityEngine_Component_GetComponent_IGuideTarget___);
		  }
		  param1[0x12] = iVar2;
		  uVar5 = Core_Data_ArtifactData__UpdateUserSkills(uVar5,iVar2,0);
		  UnityEngine_Object__op_Implicit(uVar3,uVar5,0);
		  return;
		}
		*/

		}

		// Token: 0x06002766 RID: 10086 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002766")]
		[Address(RVA = "0x7897", Offset = "0x7897", VA = "0x7897", Slot = "19")]
		protected override void HandleDataChanged()
		{
		/* --- GHIDRA: HandleDataChanged ---
		void Gameplay_Inventory_View_ArtifactView__HandleDataChanged(int *param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  undefined4 uVar3;
		  uint uVar4;
		  
		  if (DAT_ram_00a5a08d == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UI_AbstractDataRenderer_ArtifactData__CommitProperties__);
		    DAT_ram_00a5a08d = '\x01';
		  }
		  UI_AbstractDataRenderer_object____ctor
		            (param1,Method_UI_AbstractDataRenderer_ArtifactData__CommitProperties__);
		  if ((char)param1[0x10] != '\0') {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x130) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x134));
		    uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (param1[0xd],0);
		    if (iVar2 == 0) {
		      uVar4 = 0;
		    }
		    else {
		      iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x130) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x134));
		      uVar4 = (uint)(*(char *)(iVar2 + 0x68) != '\0');
		    }
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar1,uVar4,0);
		    *(undefined1 *)(param1 + 0x10) = 0;
		  }
		  if (*(char *)((int)param1 + 0x43) != '\0') {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x130) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x134));
		    uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (param1[0xc],0);
		    if (iVar2 == 0) {
		      uVar4 = 0;
		    }
		    else {
		      iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x130) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x134));
		      if (*(char *)(iVar2 + 0x79) == '\0') {
		        uVar4 = 0;
		      }
		      else {
		        iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x130) * 4))
		                          (param1,*(undefined4 *)(*param1 + 0x134));
		        uVar4 = (uint)(*(char *)(iVar2 + 0x7a) == '\0');
		      }
		    }
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar1,uVar4,0);
		    *(undefined1 *)((int)param1 + 0x43) = 0;
		  }
		  if (*(char *)((int)param1 + 0x42) != '\0') {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x130) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x134));
		    uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (param1[0xb],0);
		    if (iVar2 == 0) {
		      uVar4 = 0;
		    }
		    else {
		      iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x130) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x134));
		      uVar4 = (uint)(*(char *)(iVar2 + 0x78) != '\0');
		    }
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar1,uVar4,0);
		    *(undefined1 *)((int)param1 + 0x42) = 0;
		  }
		  if (*(char *)((int)param1 + 0x45) == '\0') goto code_r0x811c09ba;
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x130) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x134));
		  if ((iVar2 == 0) || (uVar1 = 1, (*(byte *)(param1 + 0x16) & 1) == 0)) {
		code_r0x811c099a:
		    uVar1 = 0;
		  }
		  else {
		    uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x130) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x134));
		    iVar2 = Gameplay_Inventory_Model_ArtifactDataUtils__IsInBag(uVar3,0);
		    if (iVar2 == 0) goto code_r0x811c099a;
		  }
		  uVar3 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (param1[0xe],0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar3,uVar1,0);
		  *(undefined1 *)((int)param1 + 0x45) = 0;
		code_r0x811c09ba:
		  if ((char)param1[0x11] != '\0') {
		    (**(code **)((ulonglong)*(uint *)(*param1 + 0x1c0) * 4))
		              (param1,*(undefined4 *)(*param1 + 0x1c4));
		    *(undefined1 *)(param1 + 0x11) = 0;
		  }
		  if (*(char *)((int)param1 + 0x41) != '\0') {
		    Gameplay_Inventory_View_ArtifactView__RenderBestIcon(param1,param1);
		    *(undefined1 *)((int)param1 + 0x41) = 0;
		  }
		  return;
		}
		*/

		}

		// Token: 0x06002767 RID: 10087 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002767")]
		[Address(RVA = "0x7898", Offset = "0x7898", VA = "0x7898", Slot = "5")]
		protected override void CommitProperties()
		{
		/* --- GHIDRA: CommitProperties ---
		void Gameplay_Inventory_View_ArtifactView__CommitProperties(int *param1,undefined4 param2)
		
		{
		  undefined4 param2_00;
		  int iVar1;
		  undefined4 uVar2;
		  
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x130) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x134));
		  if ((iVar1 != 0) && (param2_00 = 1, (*(byte *)(param1 + 0x16) & 1) != 0)) {
		    uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x130) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x134));
		    iVar1 = Gameplay_Inventory_Model_ArtifactDataUtils__IsInBag(uVar2,0);
		    if (iVar1 != 0) goto code_r0x811c0c48;
		  }
		  param2_00 = 0;
		code_r0x811c0c48:
		  uVar2 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (param1[0xe],0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar2,param2_00,0);
		  return;
		}
		*/

		}

		// Token: 0x06002768 RID: 10088 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002768")]
		[Address(RVA = "0x7899", Offset = "0x7899", VA = "0x7899")]
		private void RenderIsEquippedIcon()
		{
		/* --- GHIDRA: RenderIsEquippedIcon ---
		void Gameplay_Inventory_View_ArtifactView__RenderIsEquippedIcon(int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  uint param2_00;
		  
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x130) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x134));
		  param1_00 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                        (param1[0xb],0);
		  if (iVar1 == 0) {
		    param2_00 = 0;
		  }
		  else {
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x130) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x134));
		    param2_00 = (uint)(*(char *)(iVar1 + 0x78) != '\0');
		  }
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (param1_00,param2_00,0);
		  return;
		}
		*/

		}

		// Token: 0x06002769 RID: 10089 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002769")]
		[Address(RVA = "0x789A", Offset = "0x789A", VA = "0x789A")]
		private void RenderFavoriteIcon()
		{
		/* --- GHIDRA: RenderFavoriteIcon ---
		void Gameplay_Inventory_View_ArtifactView__RenderFavoriteIcon(int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  uint param2_00;
		  
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x130) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x134));
		  param1_00 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                        (param1[0xc],0);
		  if (iVar1 == 0) {
		    param2_00 = 0;
		  }
		  else {
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x130) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x134));
		    if (*(char *)(iVar1 + 0x79) == '\0') {
		      param2_00 = 0;
		    }
		    else {
		      iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x130) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x134));
		      param2_00 = (uint)(*(char *)(iVar1 + 0x7a) == '\0');
		    }
		  }
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (param1_00,param2_00,0);
		  return;
		}
		*/

		}

		// Token: 0x0600276A RID: 10090 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600276A")]
		[Address(RVA = "0x789B", Offset = "0x789B", VA = "0x789B")]
		private void RenderFreshIcon()
		{
		/* --- GHIDRA: RenderFreshIcon ---
		void Gameplay_Inventory_View_ArtifactView__RenderFreshIcon(int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  uint param2_00;
		  
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x130) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x134));
		  param1_00 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                        (param1[0xd],0);
		  if (iVar1 == 0) {
		    param2_00 = 0;
		  }
		  else {
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x130) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x134));
		    param2_00 = (uint)(*(char *)(iVar1 + 0x68) != '\0');
		  }
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (param1_00,param2_00,0);
		  return;
		}
		*/

		}

		// Token: 0x0600276B RID: 10091 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600276B")]
		[Address(RVA = "0x789C", Offset = "0x789C", VA = "0x789C")]
		private void RenderBestIcon()
		{
		/* --- GHIDRA: RenderBestIcon ---
		void Gameplay_Inventory_View_ArtifactView__RenderBestIcon(int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int *piVar3;
		  int param1_00;
		  undefined8 local_8;
		  
		  uVar2 = 0;
		  if (DAT_ram_00a5a08e == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Nullable_int___ctor__);
		    DAT_ram_00a5a08e = '\x01';
		  }
		  param1_00 = param1[10];
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x130) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x134));
		  if (iVar1 != 0) {
		    uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x130) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x134));
		    iVar1 = Gameplay_Inventory_Model_InventoryBaseModel__GetArtifactById(uVar2,0);
		    uVar2 = 0;
		    if (iVar1 != 0) {
		      piVar3 = (int *)(**(code **)((ulonglong)*(uint *)(*param1 + 0x130) * 4))
		                                (param1,*(undefined4 *)(*param1 + 0x134));
		      uVar2 = (**(code **)((ulonglong)*(uint *)(*piVar3 + 0xf8) * 4))
		                        (piVar3,*(undefined4 *)(*piVar3 + 0xfc));
		    }
		  }
		  local_8 = 0;
		  System_Data_SqlTypes_SqlInt32___ctor(&local_8,uVar2,Method_System_Nullable_int___ctor__);
		  *(undefined1 *)(param1_00 + 0x38) = 1;
		  *(undefined8 *)(param1_00 + 0x3c) = local_8;
		  UI_AbstractDeferredRenderer__KillCoroutine(param1_00,0);
		  return;
		}
		*/

		}

		// Token: 0x0600276C RID: 10092 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600276C")]
		[Address(RVA = "0x789D", Offset = "0x789D", VA = "0x789D")]
		private void RenderStackSize()
		{
		/* --- GHIDRA: RenderStackSize ---
		void Gameplay_Inventory_View_ArtifactView__RenderStackSize(int *param1,undefined4 param2)
		
		{
		  undefined4 param2_00;
		  int param1_00;
		  
		  param1_00 = param1[0xf];
		  param2_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x130) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x134));
		  Gameplay_Inventory_View_ArtifactActionsView___ctor(param1_00,param2_00,param1);
		  return;
		}
		*/

		}

		// Token: 0x0600276D RID: 10093 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600276D")]
		[Address(RVA = "0x789E", Offset = "0x789E", VA = "0x789E", Slot = "32")]
		protected virtual void UpdateStatusView()
		{
		/* --- GHIDRA: UpdateStatusView ---
		void Gameplay_Inventory_View_ArtifactView__UpdateStatusView(undefined4 param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  int param3;
		  undefined4 param2_00;
		  undefined8 local_18;
		  undefined8 local_10 [2];
		  
		  if (DAT_ram_00a5a08f == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_ContextMenu_ContextMenuController_Show_ItemContextMenuOptions__ArtifactContextMenu___
		              );
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Inventory_View_ContextMenu_ItemContextMenuOptions_TypeInfo);
		    DAT_ram_00a5a08f = '\x01';
		  }
		  uVar1 = System_Uri___ctor(0);
		  uVar1 = Google_Protobuf_Reflection_EnumValueDescriptor__get_Name(uVar1,0);
		  param3 = unnamed_function_1417
		                     (Gameplay_Inventory_View_ContextMenu_ItemContextMenuOptions_TypeInfo);
		  *(undefined4 *)(param3 + 8) = param1;
		  param2_00 = System_Collections_Generic_SortedDictionary_Enumerator_object__object___get_Current
		                        (param1,0);
		  func_ii_7888(local_10,param2_00,0);
		  local_18 = local_10[0];
		  UI_ContextMenu_ContextMenuController___Show_b__13_0___Il2CppFullySharedGenericType____Il2CppFullySharedGenericType_
		            (uVar1,2,param3,&local_18,
		             Method_UI_ContextMenu_ContextMenuController_Show_ItemContextMenuOptions__ArtifactContextMenu___
		            );
		  return;
		}
		*/

		}

		// Token: 0x0600276E RID: 10094 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600276E")]
		[Address(RVA = "0x789F", Offset = "0x789F", VA = "0x789F")]
		private void ShowContextMenu()
		{
		/* --- GHIDRA: ShowContextMenu ---
		void Gameplay_Inventory_View_ArtifactView__ShowContextMenu
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  if (param1[9] == 0) {
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x130) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x134));
		    if (iVar1 != 0) {
		      Gameplay_Inventory_View_ArtifactView__UpdateStatusView(param1,param1);
		      return;
		    }
		  }
		  else if ((param1[9] == 1) && (iVar1 = param1[0x13], iVar1 != 0)) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),param1,*(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x0600276F RID: 10095 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600276F")]
		[Address(RVA = "0x78A0", Offset = "0x78A0", VA = "0x78A0", Slot = "31")]
		public void OnPointerClick(PointerEventData eventData)
		{
		/* --- GHIDRA: OnPointerClick ---
		void Gameplay_Inventory_View_ArtifactView__OnPointerClick
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x130) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x134));
		  if (((iVar1 != 0) &&
		      (iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x130) * 4))
		                         (param1,*(undefined4 *)(*param1 + 0x134)), *(char *)(iVar1 + 0x79) != '\0')
		      ) && (iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x130) * 4))
		                              (param1,*(undefined4 *)(*param1 + 0x134)),
		           *(char *)(iVar1 + 0x7a) == '\0')) {
		    param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x130) * 4))
		                          (param1,*(undefined4 *)(*param1 + 0x134));
		    Core_Data_ArtifactData__get_IsFreshWatched(param1_00,1,0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06002770 RID: 10096 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002770")]
		[Address(RVA = "0x78A1", Offset = "0x78A1", VA = "0x78A1", Slot = "29")]
		public void OnPointerEnter(PointerEventData eventData)
		{
		/* --- GHIDRA: OnPointerEnter ---
		int Gameplay_Inventory_View_ArtifactView__OnPointerEnter(int *param1,undefined4 param2)
		
		{
		  int param1_00;
		  int iVar1;
		  undefined4 param4;
		  undefined4 param1_01;
		  undefined4 param2_00;
		  undefined4 param3;
		  
		  if (DAT_ram_00a5a090 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Inventory_Model_ToolTipArtifactInfoProvider_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_UI_ToolTip_ToolTipData_IItemInformationProvider___ctor__);
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_ToolTip_ToolTipData_IItemInformationProvider__set_Data__);
		    Mono_Security_ASN1__get_Item(&UI_ToolTip_ToolTipData_IItemInformationProvider__TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_12536);
		    DAT_ram_00a5a090 = '\x01';
		  }
		  param1_00 = unnamed_function_1417(UI_ToolTip_ToolTipData_IItemInformationProvider__TypeInfo);
		  System_Buffers_TlsOverPerCoreLockedStacksArrayPool___Il2CppFullySharedGenericType___get_Id
		            (param1_00,StringLiteral_12536,
		             Method_UI_ToolTip_ToolTipData_IItemInformationProvider___ctor__);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x130) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x134));
		  param2_00 = *(undefined4 *)(iVar1 + 0x70);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x130) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x134));
		  param3 = *(undefined4 *)(iVar1 + 0x6c);
		  param4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x130) * 4))
		                     (param1,*(undefined4 *)(*param1 + 0x134));
		  param1_01 = unnamed_function_1417(Gameplay_Inventory_Model_ToolTipArtifactInfoProvider_TypeInfo);
		  Gameplay_Inventory_Model_InventoryUtils___ctor(param1_01,param2_00,param3,param4,0);
		  *(undefined4 *)(param1_00 + 0x1c) = param1_01;
		  return param1_00;
		}
		*/

		}

		// Token: 0x06002771 RID: 10097 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6002771")]
		[Address(RVA = "0x78A2", Offset = "0x78A2", VA = "0x78A2", Slot = "30")]
		public BaseToolTipData GetData()
		{
			return null;
		}

		// Token: 0x1700076E RID: 1902
		// (get) Token: 0x06002772 RID: 10098 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700076E")]
		public GameObject GameObject
		{
			[Token(Token = "0x6002772")]
			[Address(RVA = "0x78A3", Offset = "0x78A3", VA = "0x78A3", Slot = "25")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700076F RID: 1903
		// (get) Token: 0x06002773 RID: 10099 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700076F")]
		public IActionInfo Info
		{
			[Token(Token = "0x6002773")]
			[Address(RVA = "0x78A4", Offset = "0x78A4", VA = "0x78A4", Slot = "26")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x17000770 RID: 1904
		// (get) Token: 0x06002774 RID: 10100 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000770")]
		public BackTime Backtime
		{
			[Token(Token = "0x6002774")]
			[Address(RVA = "0x78A5", Offset = "0x78A5", VA = "0x78A5", Slot = "27")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x17000771 RID: 1905
		// (get) Token: 0x06002775 RID: 10101 RVA: 0x000078C0 File Offset: 0x00005AC0
		[Token(Token = "0x17000771")]
		public bool OnlyMarketAccount
		{
			[Token(Token = "0x6002775")]
			[Address(RVA = "0x78A6", Offset = "0x78A6", VA = "0x78A6", Slot = "28")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000772 RID: 1906
		// (get) Token: 0x06002776 RID: 10102 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000772")]
		public ArtifactData ArtifactData
		{
			[Token(Token = "0x6002776")]
			[Address(RVA = "0x78A7", Offset = "0x78A7", VA = "0x78A7", Slot = "22")]
			get
			{
				return null;
			}
		}

		// Token: 0x06002777 RID: 10103 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002777")]
		[Address(RVA = "0x78A8", Offset = "0x78A8", VA = "0x78A8")]
		public ArtifactView()
		{
		}

		// Token: 0x0400158B RID: 5515
		[Token(Token = "0x400158B")]
		[FieldOffset(Offset = "0x24")]
		private InteractiveBehavior _mode;

		// Token: 0x0400158C RID: 5516
		[Token(Token = "0x400158C")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private ArtikulView _artikulView;

		// Token: 0x0400158D RID: 5517
		[Token(Token = "0x400158D")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private Image _favIcon;

		// Token: 0x0400158E RID: 5518
		[Token(Token = "0x400158E")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Image _freshIcon;

		// Token: 0x0400158F RID: 5519
		[Token(Token = "0x400158F")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private Image _bestIcon;

		// Token: 0x04001590 RID: 5520
		[Token(Token = "0x4001590")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Image _isEquippedIcon;

		// Token: 0x04001591 RID: 5521
		[Token(Token = "0x4001591")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private ArtifactStatusDisplay _statusDisplay;

		// Token: 0x04001592 RID: 5522
		[Token(Token = "0x4001592")]
		[FieldOffset(Offset = "0x40")]
		private bool _isBestChanged;

		// Token: 0x04001593 RID: 5523
		[Token(Token = "0x4001593")]
		[FieldOffset(Offset = "0x41")]
		private bool _stackSizeChanged;

		// Token: 0x04001594 RID: 5524
		[Token(Token = "0x4001594")]
		[FieldOffset(Offset = "0x42")]
		private bool _isFavoriteChanged;

		// Token: 0x04001595 RID: 5525
		[Token(Token = "0x4001595")]
		[FieldOffset(Offset = "0x43")]
		private bool _isFreshChanged;

		// Token: 0x04001596 RID: 5526
		[Token(Token = "0x4001596")]
		[FieldOffset(Offset = "0x44")]
		private bool _statusChanged;

		// Token: 0x04001597 RID: 5527
		[Token(Token = "0x4001597")]
		[FieldOffset(Offset = "0x45")]
		private bool _isEquippedChanged;

		// Token: 0x04001598 RID: 5528
		[Token(Token = "0x4001598")]
		[FieldOffset(Offset = "0x48")]
		private IGuideTarget _guideTarget;

		// Token: 0x0400159A RID: 5530
		[Token(Token = "0x400159A")]
		[FieldOffset(Offset = "0x50")]
		private ArtifactView.ArtifactViewArgs _args;

		// Token: 0x02000658 RID: 1624
		[Token(Token = "0x2000658")]
		public struct ArtifactViewArgs
		{
			// Token: 0x0400159E RID: 5534
			[Token(Token = "0x400159E")]
			[FieldOffset(Offset = "0x0")]
			public InteractiveBehavior Mode;

			// Token: 0x0400159F RID: 5535
			[Token(Token = "0x400159F")]
			[FieldOffset(Offset = "0x4")]
			public ArtikulMenuActionDic.Types.Actions[] CustomActions;

			// Token: 0x040015A0 RID: 5536
			[Token(Token = "0x40015A0")]
			[FieldOffset(Offset = "0x8")]
			public ArtifactView.ArtifactViewArgs.ArtifactViewOptions ViewOptions;

			// Token: 0x02000659 RID: 1625
			[Token(Token = "0x2000659")]
			[Flags]
			public enum ArtifactViewOptions
			{
				// Token: 0x040015A2 RID: 5538
				[Token(Token = "0x40015A2")]
				None = 0,
				// Token: 0x040015A3 RID: 5539
				[Token(Token = "0x40015A3")]
				EnableIsEquippedIcon = 1
			}
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_Mode ---
		void Gameplay_Inventory_View_ArtifactView__set_Mode(int param1,undefined4 param2)
		
		{
		  *(undefined1 *)(*(int *)(param1 + 0x28) + 0x44) = 0;
		  return;
		}
		*/


		/* --- GHIDRA: get_GuideTarget ---
		void Gameplay_Inventory_View_ArtifactView__get_GuideTarget
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5a08a == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ArtifactView__TypeInfo);
		    DAT_ram_00a5a08a = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x4c);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_ArtifactView__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ArtifactView__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0x4c,iVar2,param1_00);
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


		/* --- GHIDRA: remove_ClickEvent ---
		void Gameplay_Inventory_View_ArtifactView__remove_ClickEvent(int param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a5a08b == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UI_AbstractDataRenderer_ArtifactData__OnDataInvalidated__);
		    DAT_ram_00a5a08b = '\x01';
		  }
		  *(undefined2 *)(param1 + 0x44) = 0x101;
		  *(undefined **)(param1 + 0x40) = &DAT_ram_01010101;
		  return;
		}
		*/


		/* --- GHIDRA: get_Args ---
		void Gameplay_Inventory_View_ArtifactView__get_Args(int param1,undefined4 param2)
		
		{
		  *(undefined1 *)(param1 + 0x40) = 1;
		  UI_AbstractDeferredRenderer__KillCoroutine(param1,0);
		  return;
		}
		*/


		/* --- GHIDRA: set_Args ---
		void Gameplay_Inventory_View_ArtifactView__set_Args(int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5a089 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ArtifactView__TypeInfo);
		    DAT_ram_00a5a089 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x4c);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_ArtifactView__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ArtifactView__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0x4c,iVar2,param1_00);
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


		/* --- GHIDRA: get_ArtifactData ---
		void Gameplay_Inventory_View_ArtifactView__get_ArtifactData(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a5a091 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UI_AbstractDataRenderer_ArtifactData___ctor__);
		    DAT_ram_00a5a091 = '\x01';
		  }
		  UnityEngine_ParticleSystemRenderer__GetMeshes
		            (param1,Method_UI_AbstractDataRenderer_ArtifactData___ctor__);
		  return;
		}
		*/

}
