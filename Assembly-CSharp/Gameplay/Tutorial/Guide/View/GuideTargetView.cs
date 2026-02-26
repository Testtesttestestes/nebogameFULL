using System;
using System.Runtime.CompilerServices;
using Core;
using Gameplay.Tutorial.Guide.Control;
using Gameplay.Tutorial.Guide.Model.Data;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Gameplay.Tutorial.Guide.View
{
	// Token: 0x0200045F RID: 1119
	[Token(Token = "0x200045F")]
	public class GuideTargetView : MonoBehaviour, IGuideTarget, IPointerClickHandler, IEventSystemHandler
	{
		// Token: 0x1400012F RID: 303
		// (add) Token: 0x06001A80 RID: 6784 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06001A81 RID: 6785 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400012F")]
		private event Action<IGuideTarget> _resolveEvent
		{
			[Token(Token = "0x6001A80")]
			[Address(RVA = "0x6C14", Offset = "0x6C14", VA = "0x6C14")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6001A81")]
			[Address(RVA = "0x6C15", Offset = "0x6C15", VA = "0x6C15")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000130 RID: 304
		// (add) Token: 0x06001A82 RID: 6786 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06001A83 RID: 6787 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000130")]
		public event Action<IGuideTarget> ResolveEvent
		{
			[Token(Token = "0x6001A82")]
			[Address(RVA = "0x6C16", Offset = "0x6C16", VA = "0x6C16", Slot = "4")]
			add
			{
			}
			[Token(Token = "0x6001A83")]
			[Address(RVA = "0x6C17", Offset = "0x6C17", VA = "0x6C17", Slot = "5")]
			remove
			{
			}
		}

		// Token: 0x06001A84 RID: 6788 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A84")]
		[Address(RVA = "0x6C18", Offset = "0x6C18", VA = "0x6C18")]
		private void HandleEvtProviderResolveEvent(IGuideTargetResolveEventProvider eventProvider)
		{
		}

		// Token: 0x1700049E RID: 1182
		// (get) Token: 0x06001A85 RID: 6789 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06001A86 RID: 6790 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700049E")]
		public string Id
		{
			[Token(Token = "0x6001A85")]
			[Address(RVA = "0x6C19", Offset = "0x6C19", VA = "0x6C19", Slot = "6")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001A86")]
			[Address(RVA = "0x6C1A", Offset = "0x6C1A", VA = "0x6C1A")]
			set
			{
			}
		}

		// Token: 0x06001A87 RID: 6791 RVA: 0x00005AC0 File Offset: 0x00003CC0
		[Token(Token = "0x6001A87")]
		[Address(RVA = "0x6C1B", Offset = "0x6C1B", VA = "0x6C1B", Slot = "7")]
		public Rect GetRect(Camera camera)
		{
			return default(Rect);
		}

		// Token: 0x1700049F RID: 1183
		// (get) Token: 0x06001A88 RID: 6792 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700049F")]
		public MonoBehaviour MonoBehaviour
		{
			[Token(Token = "0x6001A88")]
			[Address(RVA = "0x6C1C", Offset = "0x6C1C", VA = "0x6C1C", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001A89 RID: 6793 RVA: 0x00005AD8 File Offset: 0x00003CD8
		[Token(Token = "0x6001A89")]
		[Address(RVA = "0x6C1D", Offset = "0x6C1D", VA = "0x6C1D", Slot = "12")]
		public virtual bool CheckParams(params long[] values)
		{
		/* --- GHIDRA: CheckParams ---
		undefined4 Gameplay_Tutorial_Guide_View_GuideTargetView__CheckParams(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a5844a == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Component_GetComponent_RectTransform___);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    DAT_ram_00a5844a = '\x01';
		  }
		  uVar2 = *(undefined4 *)(param1 + 0x18);
		  if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_Object_TypeInfo);
		  }
		  iVar1 = UnityEngine_Component__GetComponent_object_(uVar2,0);
		  if (iVar1 != 0) {
		    return *(undefined4 *)(param1 + 0x18);
		  }
		  uVar2 = func_ii_5677(param1,Method_UnityEngine_Component_GetComponent_RectTransform___);
		  *(undefined4 *)(param1 + 0x18) = uVar2;
		  return uVar2;
		}
		*/

			return default(bool);
		}

		// Token: 0x06001A8A RID: 6794 RVA: 0x00005AF0 File Offset: 0x00003CF0
		[Token(Token = "0x6001A8A")]
		public bool TryGetOverrides<T>(out T component)
		{
		/* --- GHIDRA: TryGetOverrides<__Il2CppFullySharedGenericType> ---
		undefined4
		Gameplay_Tutorial_Guide_View_GuideTargetView__TryGetOverrides___Il2CppFullySharedGenericType_
		          (int param1,undefined4 param2,undefined4 param3,int param4)
		
		{
		  undefined4 uVar1;
		  int *piVar2;
		  int iVar3;
		  int iVar4;
		  int iVar5;
		  undefined1 auStack_10 [12];
		  undefined4 local_4;
		  
		  piVar2 = *(int **)(param4 + 0x1c);
		  local_4 = param2;
		  if (piVar2 == (int *)0x0) {
		    Mono_Security_ASN1__get_Item(&System_Action_object__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Threading_CancellationToken_TypeInfo);
		    Mono_Security_ASN1__get_Item(&BestHTTP_HTTPManager_TypeInfo);
		    Mono_Security_ASN1__get_Item(&BestHTTP_OnRequestFinishedDelegate_TypeInfo);
		    piVar2 = *(int **)(param4 + 0x1c);
		    if (piVar2 == (int *)0x0) {
		      System_ReadOnlySpan_char___GetPinnableReference(param4);
		      piVar2 = *(int **)(param4 + 0x1c);
		    }
		  }
		  iVar3 = *piVar2;
		  if ((*(byte *)(iVar3 + 0xbd) & 1) == 0) {
		    iVar3 = func_ii_1079(iVar3);
		  }
		  iVar3 = unnamed_function_1417(iVar3);
		  *(undefined4 *)(iVar3 + 8) = param3;
		  if (*(int *)(BestHTTP_HTTPManager_TypeInfo + 0x74) == 0) {
		    func_ii_306000(BestHTTP_HTTPManager_TypeInfo);
		  }
		  BestHTTP_HTTPManager__set_IsQuitting(0);
		  iVar4 = *(int *)(*(int *)(param4 + 0x1c) + 0xc);
		  if ((*(byte *)(iVar4 + 0xbd) & 1) == 0) {
		    iVar4 = func_ii_1079(iVar4);
		  }
		  uVar1 = unnamed_function_1417(iVar4);
		  Unity_Services_Core_ServicesInitializationException___ctor
		            (uVar1,*(undefined4 *)(*(int *)(param4 + 0x1c) + 0x10));
		  *(undefined4 *)(iVar3 + 0xc) = uVar1;
		  uVar1 = unnamed_function_1417(BestHTTP_OnRequestFinishedDelegate_TypeInfo);
		  BestHTTP_HTTPRange__ToString(uVar1,iVar3,*(undefined4 *)(*(int *)(param4 + 0x1c) + 0x14),0);
		  *(undefined4 *)(param1 + 0x2c) = uVar1;
		  if (*(int *)(System_Threading_CancellationToken_TypeInfo + 0x74) == 0) {
		    func_ii_306000(System_Threading_CancellationToken_TypeInfo);
		  }
		  iVar4 = UnityEngine_UI_CoroutineTween_FloatTween__GetDuration(&local_4,0);
		  if (iVar4 != 0) {
		    iVar4 = *(int *)(*(int *)(param4 + 0x1c) + 0x1c);
		    if ((*(byte *)(iVar4 + 0xbd) & 1) == 0) {
		      iVar4 = func_ii_1079(iVar4);
		    }
		    if (*(int *)(iVar4 + 0x74) == 0) {
		      func_ii_306000(iVar4);
		    }
		    iVar4 = *(int *)(*(int *)(param4 + 0x1c) + 0x1c);
		    if ((*(byte *)(iVar4 + 0xbd) & 1) == 0) {
		      iVar4 = func_ii_1079(iVar4);
		    }
		    iVar4 = *(int *)(*(int *)(iVar4 + 0x5c) + 4);
		    if (iVar4 == 0) {
		      iVar4 = *(int *)(*(int *)(param4 + 0x1c) + 0x1c);
		      if ((*(byte *)(iVar4 + 0xbd) & 1) == 0) {
		        iVar4 = func_ii_1079(iVar4);
		      }
		      if (*(int *)(iVar4 + 0x74) == 0) {
		        func_ii_306000(iVar4);
		      }
		      iVar4 = *(int *)(*(int *)(param4 + 0x1c) + 0x1c);
		      if ((*(byte *)(iVar4 + 0xbd) & 1) == 0) {
		        iVar4 = func_ii_1079(iVar4);
		      }
		      uVar1 = **(undefined4 **)(iVar4 + 0x5c);
		      iVar4 = unnamed_function_1417(System_Action_object__TypeInfo);
		      UnityEngine_UIElements_VisualElement__get_layout
		                (iVar4,uVar1,*(undefined4 *)(*(int *)(param4 + 0x1c) + 0x20),0);
		      iVar5 = *(int *)(*(int *)(param4 + 0x1c) + 0x1c);
		      if ((*(byte *)(iVar5 + 0xbd) & 1) == 0) {
		        iVar5 = func_ii_1079(iVar5);
		      }
		      *(int *)(*(int *)(iVar5 + 0x5c) + 4) = iVar4;
		      iVar5 = *(int *)(*(int *)(param4 + 0x1c) + 0x1c);
		      if ((*(byte *)(iVar5 + 0xbd) & 1) == 0) {
		        func_ii_1079(iVar5);
		      }
		    }
		    if (*(int *)(System_Threading_CancellationToken_TypeInfo + 0x74) == 0) {
		      func_ii_306000(System_Threading_CancellationToken_TypeInfo);
		    }
		    System_Threading_CancellationToken__Register(auStack_10,&local_4,iVar4,param1,0);
		  }
		  if (*(int *)(param1 + 0x84) == 0) {
		    BestHTTP_HTTPRequest__CallCustomCertificationValidator(param1,0);
		  }
		  return *(undefined4 *)(*(int *)(iVar3 + 0xc) + 8);
		}
		*/

			return default(bool);
		}

		// Token: 0x170004A0 RID: 1184
		// (get) Token: 0x06001A8B RID: 6795 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170004A0")]
		public RectTransform Transform
		{
			[Token(Token = "0x6001A8B")]
			[Address(RVA = "0x6C1E", Offset = "0x6C1E", VA = "0x6C1E")]
			get
			{
				return null;
			}
		}

		// Token: 0x170004A1 RID: 1185
		// (get) Token: 0x06001A8C RID: 6796 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170004A1")]
		public IAsyncLoadableContent AsyncContent
		{
			[Token(Token = "0x6001A8C")]
			[Address(RVA = "0x6C1F", Offset = "0x6C1F", VA = "0x6C1F")]
			get
			{
				return null;
			}
		}

		// Token: 0x170004A2 RID: 1186
		// (get) Token: 0x06001A8D RID: 6797 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170004A2")]
		private IGuideTargetResolveEventProvider EvtProvider
		{
			[Token(Token = "0x6001A8D")]
			[Address(RVA = "0x6C20", Offset = "0x6C20", VA = "0x6C20")]
			get
			{
				return null;
			}
		}

		// Token: 0x170004A3 RID: 1187
		// (get) Token: 0x06001A8E RID: 6798 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170004A3")]
		public GuideController Controller
		{
			[Token(Token = "0x6001A8E")]
			[Address(RVA = "0x6C21", Offset = "0x6C21", VA = "0x6C21")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001A8F RID: 6799 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A8F")]
		[Address(RVA = "0x6C22", Offset = "0x6C22", VA = "0x6C22")]
		private void OnDestroy()
		{
		/* --- GHIDRA: OnDestroy ---
		void Gameplay_Tutorial_Guide_View_GuideTargetView__OnDestroy(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  iVar1 = Newtonsoft_Json_Serialization_JsonSerializerInternalReader__ShouldDeserialize
		                    (*(undefined4 *)(param1 + 0x10),0);
		  if (iVar1 == 0) {
		    Gameplay_Tutorial_Guide_View_GuideTargetView__OnDisable(param1,param1);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06001A90 RID: 6800 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A90")]
		[Address(RVA = "0x6C23", Offset = "0x6C23", VA = "0x6C23")]
		private void OnEnable()
		{
		/* --- GHIDRA: OnEnable ---
		void Gameplay_Tutorial_Guide_View_GuideTargetView__OnEnable(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  iVar1 = Newtonsoft_Json_Serialization_JsonSerializerInternalReader__ShouldDeserialize
		                    (*(undefined4 *)(param1 + 0x10),0);
		  if (iVar1 == 0) {
		    Gameplay_Tutorial_Guide_View_GuideTargetView__TryAdd(param1,param1);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06001A91 RID: 6801 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A91")]
		[Address(RVA = "0x6C24", Offset = "0x6C24", VA = "0x6C24")]
		private void OnDisable()
		{
		/* --- GHIDRA: OnDisable ---
		void Gameplay_Tutorial_Guide_View_GuideTargetView__OnDisable(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  int *piVar4;
		  int iVar5;
		  
		  puVar2 = (uint *)0x0;
		  if (DAT_ram_00a5844f == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IAsyncLoadableContent__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Tutorial_Guide_View_GuideTargetView_HandleAsyncLoadableContentReadyEvent__
		              );
		    Mono_Security_ASN1__get_Item(&Core_IAsyncLoadableContent_TypeInfo);
		    DAT_ram_00a5844f = '\x01';
		  }
		  if (DAT_ram_00a5844b == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UnityEngine_Component_GetComponent_IAsyncLoadableContent___);
		    DAT_ram_00a5844b = '\x01';
		  }
		  piVar4 = *(int **)(param1 + 0x1c);
		  if (piVar4 == (int *)0x0) {
		    piVar4 = (int *)func_ii_5677(param1,
		                                 Method_UnityEngine_Component_GetComponent_IAsyncLoadableContent___)
		    ;
		    *(int **)(param1 + 0x1c) = piVar4;
		    if (piVar4 == (int *)0x0) goto code_r0x80eec9d3;
		    if (DAT_ram_00a5844b == '\0') {
		      Mono_Security_ASN1__get_Item
		                (&Method_UnityEngine_Component_GetComponent_IAsyncLoadableContent___);
		      DAT_ram_00a5844b = '\x01';
		      piVar4 = *(int **)(param1 + 0x1c);
		      if (piVar4 == (int *)0x0) {
		        piVar4 = (int *)func_ii_5677(param1,
		                                     Method_UnityEngine_Component_GetComponent_IAsyncLoadableContent___
		                                    );
		        *(int **)(param1 + 0x1c) = piVar4;
		        if (piVar4 == (int *)0x0) goto code_r0x80eec9e6;
		        if (DAT_ram_00a5844b == '\0') {
		          Mono_Security_ASN1__get_Item
		                    (&Method_UnityEngine_Component_GetComponent_IAsyncLoadableContent___);
		          DAT_ram_00a5844b = '\x01';
		          piVar4 = *(int **)(param1 + 0x1c);
		          if (piVar4 == (int *)0x0) {
		            piVar4 = (int *)func_ii_5677(param1,
		                                         Method_UnityEngine_Component_GetComponent_IAsyncLoadableContent___
		                                        );
		            *(int **)(param1 + 0x1c) = piVar4;
		          }
		        }
		      }
		    }
		  }
		  iVar5 = *piVar4;
		  if ((uint *)(uint)*(ushort *)(iVar5 + 0xb6) != (uint *)0x0) {
		    do {
		      if (Core_IAsyncLoadableContent_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + (int)puVar2 * 8))
		      {
		        puVar2 = (uint *)(iVar5 + *(int *)(*(int *)(iVar5 + 0x58) + (int)puVar2 * 8 + 4) * 8 + 0xc0)
		        ;
		        goto code_r0x80eec9c2;
		      }
		      puVar2 = (uint *)((int)puVar2 + 1);
		    } while ((uint *)(uint)*(ushort *)(iVar5 + 0xb6) != puVar2);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar4,Core_IAsyncLoadableContent_TypeInfo,0);
		code_r0x80eec9c2:
		  iVar5 = (**(code **)((ulonglong)*puVar2 * 4))(piVar4,puVar2[1]);
		  if (iVar5 == 0) {
		code_r0x80eec9e6:
		    if (DAT_ram_00a5844b == '\0') {
		      Mono_Security_ASN1__get_Item
		                (&Method_UnityEngine_Component_GetComponent_IAsyncLoadableContent___);
		      DAT_ram_00a5844b = '\x01';
		    }
		    piVar4 = *(int **)(param1 + 0x1c);
		    if (piVar4 == (int *)0x0) {
		      piVar4 = (int *)func_ii_5677(param1,
		                                   Method_UnityEngine_Component_GetComponent_IAsyncLoadableContent___
		                                  );
		      *(int **)(param1 + 0x1c) = piVar4;
		    }
		    uVar1 = 0;
		    uVar3 = unnamed_function_1417(System_Action_IAsyncLoadableContent__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar3,param1,
		               Method_Gameplay_Tutorial_Guide_View_GuideTargetView_HandleAsyncLoadableContentReadyEvent__
		               ,0);
		    iVar5 = *piVar4;
		    if (*(ushort *)(iVar5 + 0xb6) != 0) {
		      do {
		        if (Core_IAsyncLoadableContent_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		          puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 200);
		          goto code_r0x80eecab2;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(piVar4,Core_IAsyncLoadableContent_TypeInfo,1);
		code_r0x80eecab2:
		    (**(code **)((ulonglong)*puVar2 * 4))(piVar4,uVar3,puVar2[1]);
		    return;
		  }
		code_r0x80eec9d3:
		  uVar3 = Gameplay_Tutorial_Guide_View_GuideTargetView__get_EvtProvider(param1,puVar2);
		  Gameplay_Tutorial_Guide_Control_GuideController__SetCurrent(uVar3,param1,0);
		  return;
		}
		*/

		}

		// Token: 0x06001A92 RID: 6802 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A92")]
		[Address(RVA = "0x6C25", Offset = "0x6C25", VA = "0x6C25")]
		private void TryAdd()
		{
		/* --- GHIDRA: TryAdd ---
		void Gameplay_Tutorial_Guide_View_GuideTargetView__TryAdd(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  uint *param2_00;
		  int *param1_00;
		  int iVar2;
		  
		  param2_00 = (uint *)0x0;
		  if (DAT_ram_00a58450 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IAsyncLoadableContent__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Tutorial_Guide_View_GuideTargetView_HandleAsyncLoadableContentReadyEvent__
		              );
		    Mono_Security_ASN1__get_Item(&Core_IAsyncLoadableContent_TypeInfo);
		    DAT_ram_00a58450 = '\x01';
		  }
		  if (DAT_ram_00a5844b == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UnityEngine_Component_GetComponent_IAsyncLoadableContent___);
		    DAT_ram_00a5844b = '\x01';
		  }
		  param1_00 = *(int **)(param1 + 0x1c);
		  if (param1_00 == (int *)0x0) {
		    param1_00 = (int *)func_ii_5677(param1,
		                                    Method_UnityEngine_Component_GetComponent_IAsyncLoadableContent___
		                                   );
		    *(int **)(param1 + 0x1c) = param1_00;
		    if (param1_00 == (int *)0x0) goto code_r0x80eed71f;
		    if (DAT_ram_00a5844b == '\0') {
		      Mono_Security_ASN1__get_Item
		                (&Method_UnityEngine_Component_GetComponent_IAsyncLoadableContent___);
		      DAT_ram_00a5844b = '\x01';
		      param1_00 = *(int **)(param1 + 0x1c);
		      if (param1_00 == (int *)0x0) {
		        param1_00 = (int *)func_ii_5677(param1,
		                                        Method_UnityEngine_Component_GetComponent_IAsyncLoadableContent___
		                                       );
		        *(int **)(param1 + 0x1c) = param1_00;
		      }
		    }
		  }
		  uVar1 = unnamed_function_1417(System_Action_IAsyncLoadableContent__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar1,param1,
		             Method_Gameplay_Tutorial_Guide_View_GuideTargetView_HandleAsyncLoadableContentReadyEvent__
		             ,0);
		  iVar2 = *param1_00;
		  if ((uint *)(uint)*(ushort *)(iVar2 + 0xb6) != (uint *)0x0) {
		    do {
		      if (Core_IAsyncLoadableContent_TypeInfo ==
		          *(int *)(*(int *)(iVar2 + 0x58) + (int)param2_00 * 8)) {
		        param2_00 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + (int)param2_00 * 8 + 4) * 8 + iVar2 +
		                            0xd0);
		        goto code_r0x80eed711;
		      }
		      param2_00 = (uint *)((int)param2_00 + 1);
		    } while ((uint *)(uint)*(ushort *)(iVar2 + 0xb6) != param2_00);
		  }
		  param2_00 = (uint *)func_ii_1080(param1_00,Core_IAsyncLoadableContent_TypeInfo,2);
		code_r0x80eed711:
		  (**(code **)((ulonglong)*param2_00 * 4))(param1_00,uVar1,param2_00[1]);
		code_r0x80eed71f:
		  uVar1 = Gameplay_Tutorial_Guide_View_GuideTargetView__get_EvtProvider(param1,param2_00);
		  Gameplay_Tutorial_Guide_Control_GuideController__TryAdd(uVar1,param1,0);
		  return;
		}
		*/

		}

		// Token: 0x06001A93 RID: 6803 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A93")]
		[Address(RVA = "0x6C26", Offset = "0x6C26", VA = "0x6C26")]
		private void TryRemove()
		{
		/* --- GHIDRA: TryRemove ---
		void Gameplay_Tutorial_Guide_View_GuideTargetView__TryRemove
		               (undefined4 param1,int *param2,undefined4 param3)
		
		{
		  uint uVar1;
		  undefined4 param1_00;
		  uint *param2_00;
		  int iVar2;
		  
		  if (DAT_ram_00a58451 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IAsyncLoadableContent__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Tutorial_Guide_View_GuideTargetView_HandleAsyncLoadableContentReadyEvent__
		              );
		    Mono_Security_ASN1__get_Item(&Core_IAsyncLoadableContent_TypeInfo);
		    DAT_ram_00a58451 = '\x01';
		  }
		  param1_00 = unnamed_function_1417(System_Action_IAsyncLoadableContent__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_00,param1,
		             Method_Gameplay_Tutorial_Guide_View_GuideTargetView_HandleAsyncLoadableContentReadyEvent__
		             ,0);
		  iVar2 = *param2;
		  if (*(ushort *)(iVar2 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_IAsyncLoadableContent_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		        param2_00 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 0xd0);
		        goto code_r0x80eed7f2;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		  }
		  param2_00 = (uint *)func_ii_1080(param2,Core_IAsyncLoadableContent_TypeInfo,2);
		code_r0x80eed7f2:
		  (**(code **)((ulonglong)*param2_00 * 4))(param2,param1_00,param2_00[1]);
		  Gameplay_Tutorial_Guide_View_GuideTargetView__OnDisable(param1,param2_00);
		  return;
		}
		*/

		}

		// Token: 0x06001A94 RID: 6804 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A94")]
		[Address(RVA = "0x6C27", Offset = "0x6C27", VA = "0x6C27")]
		private void HandleAsyncLoadableContentReadyEvent(IAsyncLoadableContent content)
		{
		}

		// Token: 0x06001A95 RID: 6805 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A95")]
		[Address(RVA = "0x6C28", Offset = "0x6C28", VA = "0x6C28", Slot = "11")]
		public void OnPointerClick(PointerEventData eventData)
		{
		}

		// Token: 0x06001A96 RID: 6806 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A96")]
		[Address(RVA = "0x6C29", Offset = "0x6C29", VA = "0x6C29")]
		public GuideTargetView()
		{
		/* --- GHIDRA: .ctor ---
		undefined4 Gameplay_Tutorial_Guide_View_GuideTargetView___ctor(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  uVar1 = System_Collections_Generic_SortedDictionary_Enumerator_object__object___get_Current
		                    (*(undefined4 *)(param1 + 0x14),0);
		  return uVar1;
		}
		*/

		}

		// Token: 0x04000E4F RID: 3663
		[Token(Token = "0x4000E4F")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private string _id;

		// Token: 0x04000E51 RID: 3665
		[Token(Token = "0x4000E51")]
		[FieldOffset(Offset = "0x18")]
		private RectTransform _rectTransform;

		// Token: 0x04000E52 RID: 3666
		[Token(Token = "0x4000E52")]
		[FieldOffset(Offset = "0x1C")]
		private IAsyncLoadableContent _asyncContent;

		// Token: 0x04000E53 RID: 3667
		[Token(Token = "0x4000E53")]
		[FieldOffset(Offset = "0x20")]
		private IGuideTargetResolveEventProvider _evtProvider;

		// Token: 0x04000E54 RID: 3668
		[Token(Token = "0x4000E54")]
		[FieldOffset(Offset = "0x24")]
		private GuideController _controller;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: add__resolveEvent ---
		void Gameplay_Tutorial_Guide_View_GuideTargetView__add__resolveEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a58445 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IGuideTarget__TypeInfo);
		    DAT_ram_00a58445 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x14);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_IGuideTarget__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_IGuideTarget__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0x14,iVar2,param1_00);
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


		/* --- GHIDRA: remove__resolveEvent ---
		void Gameplay_Tutorial_Guide_View_GuideTargetView__remove__resolveEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  uint uVar2;
		  int iVar3;
		  int param1_00;
		  undefined4 uVar4;
		  uint *puVar5;
		  int *param1_01;
		  int iVar6;
		  
		  if (DAT_ram_00a58446 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IGuideTargetResolveEventProvider__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Tutorial_Guide_View_GuideTargetView_HandleEvtProviderResolveEvent__)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Tutorial_Guide_View_IGuideTargetResolveEventProvider_TypeInfo);
		    DAT_ram_00a58446 = '\x01';
		  }
		  if (DAT_ram_00a58444 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IGuideTarget__TypeInfo);
		    DAT_ram_00a58444 = '\x01';
		  }
		  iVar6 = *(int *)(param1 + 0x14);
		  do {
		    iVar3 = 0;
		    param1_00 = UnityEngine_UI_Image__set_sprite(iVar6,param2,0);
		    uVar4 = System_Action_IGuideTarget__TypeInfo;
		    if ((param1_00 != 0) &&
		       (iVar3 = func_ii_1082(param1_00,System_Action_IGuideTarget__TypeInfo), iVar3 == 0)) {
		      System_Activator__CreateInstance(param1_00,uVar4);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    iVar3 = func_ii_4329(param1 + 0x14,iVar3,iVar6);
		    bVar1 = iVar3 != iVar6;
		    iVar6 = iVar3;
		  } while (bVar1);
		  if (DAT_ram_00a5844c == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UnityEngine_Component_GetComponent_IGuideTargetResolveEventProvider___);
		    DAT_ram_00a5844c = '\x01';
		  }
		  param1_01 = *(int **)(param1 + 0x20);
		  if (param1_01 == (int *)0x0) {
		    param1_01 = (int *)func_ii_5677(param1,
		                                    Method_UnityEngine_Component_GetComponent_IGuideTargetResolveEventProvider___
		                                   );
		    *(int **)(param1 + 0x20) = param1_01;
		    if (param1_01 == (int *)0x0) {
		      return;
		    }
		    if (DAT_ram_00a5844c == '\0') {
		      Mono_Security_ASN1__get_Item
		                (&Method_UnityEngine_Component_GetComponent_IGuideTargetResolveEventProvider___);
		      DAT_ram_00a5844c = '\x01';
		      param1_01 = *(int **)(param1 + 0x20);
		      if (param1_01 == (int *)0x0) {
		        param1_01 = (int *)func_ii_5677(param1,
		                                        Method_UnityEngine_Component_GetComponent_IGuideTargetResolveEventProvider___
		                                       );
		        *(int **)(param1 + 0x20) = param1_01;
		      }
		    }
		  }
		  uVar2 = 0;
		  uVar4 = unnamed_function_1417(System_Action_IGuideTargetResolveEventProvider__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar4,param1,
		             Method_Gameplay_Tutorial_Guide_View_GuideTargetView_HandleEvtProviderResolveEvent__,0);
		  iVar6 = *param1_01;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    do {
		      if (Gameplay_Tutorial_Guide_View_IGuideTargetResolveEventProvider_TypeInfo ==
		          *(int *)(*(int *)(iVar6 + 0x58) + uVar2 * 8)) {
		        puVar5 = (uint *)(iVar6 + *(int *)(*(int *)(iVar6 + 0x58) + uVar2 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x80eec5da;
		      }
		      uVar2 = uVar2 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar2);
		  }
		  puVar5 = (uint *)func_ii_1080(param1_01,
		                                Gameplay_Tutorial_Guide_View_IGuideTargetResolveEventProvider_TypeInfo
		                                ,0);
		code_r0x80eec5da:
		  (**(code **)((ulonglong)*puVar5 * 4))(param1_01,uVar4,puVar5[1]);
		  return;
		}
		*/


		/* --- GHIDRA: add_ResolveEvent ---
		void Gameplay_Tutorial_Guide_View_GuideTargetView__add_ResolveEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  uint uVar2;
		  int iVar3;
		  int param1_00;
		  undefined4 uVar4;
		  uint *puVar5;
		  int *param1_01;
		  int iVar6;
		  
		  if (DAT_ram_00a58447 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IGuideTargetResolveEventProvider__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Tutorial_Guide_View_GuideTargetView_HandleEvtProviderResolveEvent__)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Tutorial_Guide_View_IGuideTargetResolveEventProvider_TypeInfo);
		    DAT_ram_00a58447 = '\x01';
		  }
		  if (DAT_ram_00a58445 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IGuideTarget__TypeInfo);
		    DAT_ram_00a58445 = '\x01';
		  }
		  iVar6 = *(int *)(param1 + 0x14);
		  do {
		    iVar3 = 0;
		    param1_00 = func_ii_7048(iVar6,param2,0);
		    uVar4 = System_Action_IGuideTarget__TypeInfo;
		    if ((param1_00 != 0) &&
		       (iVar3 = func_ii_1082(param1_00,System_Action_IGuideTarget__TypeInfo), iVar3 == 0)) {
		      System_Activator__CreateInstance(param1_00,uVar4);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    iVar3 = func_ii_4329(param1 + 0x14,iVar3,iVar6);
		    bVar1 = iVar3 != iVar6;
		    iVar6 = iVar3;
		  } while (bVar1);
		  if (DAT_ram_00a5844c == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UnityEngine_Component_GetComponent_IGuideTargetResolveEventProvider___);
		    DAT_ram_00a5844c = '\x01';
		  }
		  param1_01 = *(int **)(param1 + 0x20);
		  if (param1_01 == (int *)0x0) {
		    param1_01 = (int *)func_ii_5677(param1,
		                                    Method_UnityEngine_Component_GetComponent_IGuideTargetResolveEventProvider___
		                                   );
		    *(int **)(param1 + 0x20) = param1_01;
		    if (param1_01 == (int *)0x0) {
		      return;
		    }
		    if (DAT_ram_00a5844c == '\0') {
		      Mono_Security_ASN1__get_Item
		                (&Method_UnityEngine_Component_GetComponent_IGuideTargetResolveEventProvider___);
		      DAT_ram_00a5844c = '\x01';
		      param1_01 = *(int **)(param1 + 0x20);
		      if (param1_01 == (int *)0x0) {
		        param1_01 = (int *)func_ii_5677(param1,
		                                        Method_UnityEngine_Component_GetComponent_IGuideTargetResolveEventProvider___
		                                       );
		        *(int **)(param1 + 0x20) = param1_01;
		      }
		    }
		  }
		  uVar2 = 0;
		  uVar4 = unnamed_function_1417(System_Action_IGuideTargetResolveEventProvider__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar4,param1,
		             Method_Gameplay_Tutorial_Guide_View_GuideTargetView_HandleEvtProviderResolveEvent__,0);
		  iVar6 = *param1_01;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    do {
		      if (Gameplay_Tutorial_Guide_View_IGuideTargetResolveEventProvider_TypeInfo ==
		          *(int *)(*(int *)(iVar6 + 0x58) + uVar2 * 8)) {
		        puVar5 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar2 * 8 + 4) * 8 + iVar6 + 200);
		        goto code_r0x80eec7e7;
		      }
		      uVar2 = uVar2 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar2);
		  }
		  puVar5 = (uint *)func_ii_1080(param1_01,
		                                Gameplay_Tutorial_Guide_View_IGuideTargetResolveEventProvider_TypeInfo
		                                ,1);
		code_r0x80eec7e7:
		  (**(code **)((ulonglong)*puVar5 * 4))(param1_01,uVar4,puVar5[1]);
		  return;
		}
		*/


		/* --- GHIDRA: remove_ResolveEvent ---
		void Gameplay_Tutorial_Guide_View_GuideTargetView__remove_ResolveEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  iVar1 = *(int *)(param1 + 0x14);
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		            (*(undefined4 *)(iVar1 + 0x20),param1,*(undefined4 *)(iVar1 + 0x14));
		  return;
		}
		*/


		/* --- GHIDRA: get_Id ---
		void Gameplay_Tutorial_Guide_View_GuideTargetView__get_Id
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  
		  iVar1 = System_Collections_CollectionBase___ctor(*(undefined4 *)(param1 + 0x10),param2,0);
		  if (iVar1 == 0) {
		    uVar2 = *(undefined4 *)(param1 + 0x10);
		    *(undefined4 *)(param1 + 0x10) = param2;
		    iVar1 = Newtonsoft_Json_Serialization_JsonSerializerInternalReader__ShouldDeserialize(uVar2,0);
		    if (iVar1 != 0) {
		      uVar2 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                        (param1,0);
		      iVar1 = UnityEngine_InputSystem_Users_InputUser__UnpairDevices(uVar2,0);
		      if (iVar1 != 0) {
		        Gameplay_Tutorial_Guide_View_GuideTargetView__OnDisable(param1,param1);
		      }
		    }
		  }
		  return;
		}
		*/


		/* --- GHIDRA: set_Id ---
		void Gameplay_Tutorial_Guide_View_GuideTargetView__set_Id
		               (float4 *param1,int param2,undefined4 param3,undefined4 param4)
		
		{
		  int *piVar1;
		  uint *puVar2;
		  int iVar3;
		  undefined4 param2_00;
		  undefined4 uVar4;
		  uint uVar5;
		  float4 local_10;
		  float4 local_18;
		  undefined8 local_60;
		  undefined4 local_58;
		  undefined1 local_50 [16];
		  undefined8 local_40;
		  float4 local_34;
		  float4 local_30;
		  undefined4 local_2c;
		  undefined8 local_28;
		  undefined8 local_20;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a58448 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Component_GetComponent_IBoundsProvider___);
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Component_GetComponent_IRectProvider___);
		    Mono_Security_ASN1__get_Item(&UI_IBoundsProvider_TypeInfo);
		    Mono_Security_ASN1__get_Item(&UI_IRectProvider_TypeInfo);
		    DAT_ram_00a58448 = '\x01';
		  }
		  piVar1 = (int *)func_ii_5677(param2,Method_UnityEngine_Component_GetComponent_IBoundsProvider___);
		  if (piVar1 == (int *)0x0) {
		    piVar1 = (int *)func_ii_5677(param2,Method_UnityEngine_Component_GetComponent_IRectProvider___);
		    if (piVar1 == (int *)0x0) {
		      if (DAT_ram_00a5844a == '\0') {
		        Mono_Security_ASN1__get_Item(&Method_UnityEngine_Component_GetComponent_RectTransform___);
		        Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		        DAT_ram_00a5844a = '\x01';
		      }
		      uVar4 = *(undefined4 *)(param2 + 0x18);
		      if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		        func_ii_306000(UnityEngine_Object_TypeInfo);
		      }
		      iVar3 = UnityEngine_Component__GetComponent_object_(uVar4,0);
		      if (iVar3 == 0) {
		        uVar4 = func_ii_5677(param2,Method_UnityEngine_Component_GetComponent_RectTransform___);
		        *(undefined4 *)(param2 + 0x18) = uVar4;
		      }
		      else {
		        uVar4 = *(undefined4 *)(param2 + 0x18);
		      }
		      param2_00 = System_Collections_Generic_SortedDictionary_Enumerator_object__object___get_Current
		                            (param2,0);
		      UnityEngine_RectTransform__remove_reapplyDrivenProperties(&local_18,uVar4,0);
		      local_2c = 0;
		      local_58 = 0;
		      local_30 = (float4)((float)local_18 + (float)local_10 * 0.5);
		      local_34 = (float4)((float)local_18 + (float)local_10 * 0.5);
		      local_60 = CONCAT44(local_30,local_34);
		      UnityEngine_Transform__TransformVector(&local_18,param2_00,&local_60,0);
		      UnityEngine_RectTransform__remove_reapplyDrivenProperties(&local_18,uVar4,0);
		      *(ulonglong *)(param1 + 2) = CONCAT44(local_10,local_10);
		      param1[1] = local_18;
		      *param1 = local_18;
		    }
		    else {
		      iVar3 = *piVar1;
		      if (*(ushort *)(iVar3 + 0xb6) != 0) {
		        uVar5 = 0;
		        do {
		          if (UI_IRectProvider_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar5 * 8)) {
		            puVar2 = (uint *)(iVar3 + *(int *)(*(int *)(iVar3 + 0x58) + uVar5 * 8 + 4) * 8 + 0xc0);
		            goto code_r0x80eecd5e;
		          }
		          uVar5 = uVar5 + 1;
		        } while (*(ushort *)(iVar3 + 0xb6) != uVar5);
		      }
		      puVar2 = (uint *)func_ii_1080(piVar1,UI_IRectProvider_TypeInfo,0);
		code_r0x80eecd5e:
		      (**(code **)((ulonglong)*puVar2 * 4))(&local_18,piVar1,puVar2[1]);
		      *(ulonglong *)(param1 + 2) = CONCAT44(local_10,local_10);
		      *(ulonglong *)param1 = CONCAT44(local_18,local_18);
		    }
		  }
		  else {
		    uVar5 = 0;
		    iVar3 = *piVar1;
		    if (*(ushort *)(iVar3 + 0xb6) != 0) {
		      do {
		        if (UI_IBoundsProvider_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar5 * 8)) {
		          puVar2 = (uint *)(iVar3 + *(int *)(*(int *)(iVar3 + 0x58) + uVar5 * 8 + 4) * 8 + 0xc0);
		          goto code_r0x80eecc80;
		        }
		        uVar5 = uVar5 + 1;
		      } while (*(ushort *)(iVar3 + 0xb6) != uVar5);
		    }
		    puVar2 = (uint *)func_ii_1080(piVar1,UI_IBoundsProvider_TypeInfo,0);
		code_r0x80eecc80:
		    (**(code **)((ulonglong)*puVar2 * 4))(&local_18,piVar1,puVar2[1]);
		    local_40 = local_8;
		    Core_Files_Android_FileManager__Load_d__1__SetStateMachine(&local_28,local_50,param3,0);
		    *(undefined8 *)(param1 + 2) = local_20;
		    *(undefined8 *)param1 = local_28;
		  }
		  return;
		}
		*/


		/* --- GHIDRA: get_MonoBehaviour ---
		int Gameplay_Tutorial_Guide_View_GuideTargetView__get_MonoBehaviour
		              (int param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  int iVar2;
		  int *piVar3;
		  undefined4 uVar4;
		  uint *puVar5;
		  undefined4 *puVar6;
		  longlong lVar7;
		  int iVar8;
		  int iVar9;
		  int iVar10;
		  int iVar11;
		  int param3_00;
		  int *piVar12;
		  int iVar13;
		  uint uVar14;
		  int local_10;
		  int **local_c;
		  int *local_8;
		  int *local_4;
		  
		  iVar8 = 0;
		  if (DAT_ram_00a58449 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IEnumerable_GuideConfig__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IEnumerator_GuideConfig__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_IEnumerator_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_long__get_Count__);
		    Mono_Security_ASN1__get_Item(&Method_Google_Protobuf_Collections_RepeatedField_long__get_Item__)
		    ;
		    DAT_ram_00a58449 = '\x01';
		  }
		  local_4 = (int *)0x0;
		  iVar2 = Gameplay_Tutorial_Guide_View_GuideTargetView__get_EvtProvider(param1,param1);
		  if (iVar2 != 0) {
		    piVar3 = (int *)Gameplay_Tutorial_Guide_View_GuideTargetView__get_EvtProvider(param1,param1);
		    uVar4 = (**(code **)((ulonglong)*(uint *)(*piVar3 + 0x100) * 4))
		                      (piVar3,*(undefined4 *)(*piVar3 + 0x104));
		    iVar2 = Gameplay_Tutorial_Guide_View_Components_ShapePointer_ShapeSpriteConfig___ctor(uVar4,0);
		    if ((iVar2 != 0) &&
		       (iVar2 = Gameplay_Tutorial_Guide_Model_GuideModel___ctor
		                          (uVar4,*(undefined4 *)(param1 + 0x10),&local_4,0), piVar3 = local_4,
		       iVar2 != 0)) {
		      uVar14 = 0;
		      iVar8 = *local_4;
		      if (*(ushort *)(iVar8 + 0xb6) != 0) {
		        do {
		          if (System_Collections_Generic_IEnumerable_GuideConfig__TypeInfo ==
		              *(int *)(*(int *)(iVar8 + 0x58) + uVar14 * 8)) {
		            puVar5 = (uint *)(iVar8 + *(int *)(*(int *)(iVar8 + 0x58) + uVar14 * 8 + 4) * 8 + 0xc0);
		            goto code_r0x80eed02b;
		          }
		          uVar14 = uVar14 + 1;
		        } while (*(ushort *)(iVar8 + 0xb6) != uVar14);
		      }
		      puVar5 = (uint *)func_ii_1080(local_4,
		                                    System_Collections_Generic_IEnumerable_GuideConfig__TypeInfo,0);
		code_r0x80eed02b:
		      local_8 = (int *)(**(code **)((ulonglong)*puVar5 * 4))(piVar3,puVar5[1]);
		      local_10 = 0;
		      local_c = &local_8;
		      do {
		        piVar3 = local_8;
		        iVar2 = 0;
		        iVar8 = *local_8;
		        if (*(ushort *)(iVar8 + 0xb6) != 0) {
		          uVar14 = 0;
		          do {
		            piVar12 = (int *)(*(int *)(iVar8 + 0x58) + uVar14 * 8);
		            if (System_Collections_IEnumerator_TypeInfo == *piVar12) {
		              puVar6 = (undefined4 *)(iVar8 + piVar12[1] * 8 + 0xc0);
		              goto code_r0x80eed0f7;
		            }
		            uVar14 = uVar14 + 1;
		          } while (*(ushort *)(iVar8 + 0xb6) != uVar14);
		        }
		        DAT_ram_009d3e38 = 0;
		        puVar6 = (undefined4 *)
		                 import::env::invoke_iiii
		                           (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_8,
		                            System_Collections_IEnumerator_TypeInfo,0);
		        if (DAT_ram_009d3e38 == 1) {
		code_r0x80eed2be:
		          DAT_ram_009d3e38 = 0;
		          uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80eed2da:
		          iVar8 = global_1;
		          iVar2 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		          if (iVar8 == iVar2) {
		            piVar3 = (int *)import::env::__cxa_begin_catch(uVar4);
		            iVar2 = *piVar3;
		            iVar8 = 0;
		            DAT_ram_009d3e38 = 0;
		            local_10 = iVar2;
		            import::env::invoke_v(0x123);
		            iVar13 = DAT_ram_009d3e38;
		            DAT_ram_009d3e38 = 0;
		            if (iVar13 != 1) break;
		            uVar4 = import::env::__cxa_find_matching_catch_2();
		          }
		          DAT_ram_009d3e38 = 0;
		          import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x16b,&local_10);
		          iVar8 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar8 == 1) {
		            import::env::__cxa_find_matching_catch_3(0);
		            unnamed_function_937();
		            do {
		              halt_trap();
		            } while( true );
		          }
		          import::env::__resumeException(uVar4);
		          do {
		            halt_trap();
		          } while( true );
		        }
		code_r0x80eed0f7:
		        DAT_ram_009d3e38 = 0;
		        iVar8 = import::env::invoke_iii(*puVar6,piVar3,puVar6[1]);
		        piVar3 = local_8;
		        if (DAT_ram_009d3e38 == 1) goto code_r0x80eed2be;
		        if (iVar8 == 0) {
		          iVar8 = 0;
		          break;
		        }
		        iVar2 = *local_8;
		        if (*(ushort *)(iVar2 + 0xb6) != 0) {
		          uVar14 = 0;
		          do {
		            piVar12 = (int *)(*(int *)(iVar2 + 0x58) + uVar14 * 8);
		            if (System_Collections_Generic_IEnumerator_GuideConfig__TypeInfo == *piVar12) {
		              puVar6 = (undefined4 *)(iVar2 + piVar12[1] * 8 + 0xc0);
		              goto code_r0x80eed1d1;
		            }
		            uVar14 = uVar14 + 1;
		          } while (*(ushort *)(iVar2 + 0xb6) != uVar14);
		        }
		        DAT_ram_009d3e38 = 0;
		        puVar6 = (undefined4 *)
		                 import::env::invoke_iiii
		                           (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_8,
		                            System_Collections_Generic_IEnumerator_GuideConfig__TypeInfo,0);
		        if (DAT_ram_009d3e38 == 1) {
		code_r0x80eed2c8:
		          DAT_ram_009d3e38 = 0;
		          uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x80eed2da;
		        }
		code_r0x80eed1d1:
		        DAT_ram_009d3e38 = 0;
		        iVar13 = import::env::invoke_iii(*puVar6,piVar3,puVar6[1]);
		        if (DAT_ram_009d3e38 == 1) goto code_r0x80eed2c8;
		        iVar2 = 0;
		        iVar10 = 0;
		        iVar11 = 0;
		        param3_00 = 0;
		        iVar9 = *(int *)(*(int *)(*(int *)(iVar13 + 0x10) + 0x1c) + 0xc);
		        if (iVar9 < 1) break;
		        do {
		          DAT_ram_009d3e38 = 0;
		          lVar7 = unnamed_function_184059
		                            (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x16a,
		                             *(undefined4 *)(*(int *)(iVar13 + 0x10) + 0x1c),param3_00,
		                             Method_Google_Protobuf_Collections_RepeatedField_long__get_Item__);
		          iVar1 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar1 == 1) {
		            uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		            goto code_r0x80eed2da;
		          }
		          if (lVar7 != 0) {
		            iVar10 = iVar10 + 1;
		            if (lVar7 != *(longlong *)(param2 + param3_00 * 8 + 0x10)) break;
		            iVar11 = iVar11 + 1;
		          }
		          param3_00 = param3_00 + 1;
		        } while (param3_00 != iVar9);
		      } while (iVar10 != iVar11);
		      piVar3 = local_8;
		      DAT_ram_009d3e38 = 0;
		      if (local_8 != (int *)0x0) {
		        uVar14 = 0;
		        iVar13 = *local_8;
		        if (*(ushort *)(iVar13 + 0xb6) != 0) {
		          do {
		            if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar13 + 0x58) + uVar14 * 8)) {
		              puVar5 = (uint *)(iVar13 + *(int *)(*(int *)(iVar13 + 0x58) + uVar14 * 8 + 4) * 8 +
		                               0xc0);
		              goto code_r0x80eed39f;
		            }
		            uVar14 = uVar14 + 1;
		          } while (*(ushort *)(iVar13 + 0xb6) != uVar14);
		        }
		        puVar5 = (uint *)func_ii_1080(local_8,System_IDisposable_TypeInfo,0);
		code_r0x80eed39f:
		        (**(code **)((ulonglong)*puVar5 * 4))(piVar3,puVar5[1]);
		      }
		      if (iVar2 != 0) {
		        System_Data_DataSet__ValidateLocaleConstraint(iVar2);
		        do {
		          halt_trap();
		        } while( true );
		      }
		    }
		  }
		  return iVar8;
		}
		*/


		/* --- GHIDRA: get_Transform ---
		int Gameplay_Tutorial_Guide_View_GuideTargetView__get_Transform(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a5844b == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UnityEngine_Component_GetComponent_IAsyncLoadableContent___);
		    DAT_ram_00a5844b = '\x01';
		  }
		  iVar1 = *(int *)(param1 + 0x1c);
		  if (iVar1 == 0) {
		    iVar1 = func_ii_5677(param1,Method_UnityEngine_Component_GetComponent_IAsyncLoadableContent___);
		    *(int *)(param1 + 0x1c) = iVar1;
		  }
		  return iVar1;
		}
		*/


		/* --- GHIDRA: get_AsyncContent ---
		int Gameplay_Tutorial_Guide_View_GuideTargetView__get_AsyncContent(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a5844c == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UnityEngine_Component_GetComponent_IGuideTargetResolveEventProvider___);
		    DAT_ram_00a5844c = '\x01';
		  }
		  iVar1 = *(int *)(param1 + 0x20);
		  if (iVar1 == 0) {
		    iVar1 = func_ii_5677(param1,
		                         Method_UnityEngine_Component_GetComponent_IGuideTargetResolveEventProvider___
		                        );
		    *(int *)(param1 + 0x20) = iVar1;
		  }
		  return iVar1;
		}
		*/


		/* --- GHIDRA: get_EvtProvider ---
		int Gameplay_Tutorial_Guide_View_GuideTargetView__get_EvtProvider(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  int iVar3;
		  int *param1_00;
		  
		  if (DAT_ram_00a5844d == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a5844d = '\x01';
		  }
		  iVar3 = *(int *)(param1 + 0x24);
		  if (iVar3 == 0) {
		    if (DAT_ram_00a6456f == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		      DAT_ram_00a6456f = '\x01';
		    }
		    param1_00 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		    iVar3 = *param1_00;
		    if (*(ushort *)(iVar3 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		          puVar2 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0x1e8);
		          goto code_r0x80eecb86;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,0x25);
		code_r0x80eecb86:
		    iVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		    iVar3 = *(int *)(iVar3 + 0x10);
		  }
		  *(int *)(param1 + 0x24) = iVar3;
		  return iVar3;
		}
		*/


		/* --- GHIDRA: get_Controller ---
		void Gameplay_Tutorial_Guide_View_GuideTargetView__get_Controller(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  undefined4 param1_00;
		  uint *puVar2;
		  int *param1_01;
		  int iVar3;
		  
		  if (DAT_ram_00a5844e == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IGuideTargetResolveEventProvider__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Tutorial_Guide_View_GuideTargetView_HandleEvtProviderResolveEvent__)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Tutorial_Guide_View_IGuideTargetResolveEventProvider_TypeInfo);
		    DAT_ram_00a5844e = '\x01';
		  }
		  *(undefined4 *)(param1 + 0x14) = 0;
		  if (DAT_ram_00a5844c == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UnityEngine_Component_GetComponent_IGuideTargetResolveEventProvider___);
		    DAT_ram_00a5844c = '\x01';
		  }
		  param1_01 = *(int **)(param1 + 0x20);
		  if (param1_01 == (int *)0x0) {
		    param1_01 = (int *)func_ii_5677(param1,
		                                    Method_UnityEngine_Component_GetComponent_IGuideTargetResolveEventProvider___
		                                   );
		    *(int **)(param1 + 0x20) = param1_01;
		    if (param1_01 == (int *)0x0) {
		      return;
		    }
		    if (DAT_ram_00a5844c == '\0') {
		      Mono_Security_ASN1__get_Item
		                (&Method_UnityEngine_Component_GetComponent_IGuideTargetResolveEventProvider___);
		      DAT_ram_00a5844c = '\x01';
		      param1_01 = *(int **)(param1 + 0x20);
		      if (param1_01 == (int *)0x0) {
		        param1_01 = (int *)func_ii_5677(param1,
		                                        Method_UnityEngine_Component_GetComponent_IGuideTargetResolveEventProvider___
		                                       );
		        *(int **)(param1 + 0x20) = param1_01;
		      }
		    }
		  }
		  uVar1 = 0;
		  param1_00 = unnamed_function_1417(System_Action_IGuideTargetResolveEventProvider__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_00,param1,
		             Method_Gameplay_Tutorial_Guide_View_GuideTargetView_HandleEvtProviderResolveEvent__,0);
		  iVar3 = *param1_01;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    do {
		      if (Gameplay_Tutorial_Guide_View_IGuideTargetResolveEventProvider_TypeInfo ==
		          *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 200);
		        goto code_r0x80eed591;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_01,
		                                Gameplay_Tutorial_Guide_View_IGuideTargetResolveEventProvider_TypeInfo
		                                ,1);
		code_r0x80eed591:
		  (**(code **)((ulonglong)*puVar2 * 4))(param1_01,param1_00,puVar2[1]);
		  return;
		}
		*/

}
