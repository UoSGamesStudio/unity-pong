// GENERATED AUTOMATICALLY FROM 'Assets/Input/PaddleControls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

namespace ShefGDS.Input
{
    public class @PaddleControls : IInputActionCollection, IDisposable
    {
        public InputActionAsset asset { get; }
        public @PaddleControls()
        {
            asset = InputActionAsset.FromJson(@"{
    ""name"": ""PaddleControls"",
    ""maps"": [
        {
            ""name"": ""KeyboardLeft"",
            ""id"": ""de335810-88c6-4439-87ab-4ea90158f76d"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""9bda29b0-aee8-4163-b053-454cdbb487ea"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": ""Press(behavior=1)""
                },
                {
                    ""name"": ""Attack"",
                    ""type"": ""Button"",
                    ""id"": ""c5c78abf-e658-46c7-80e0-eeff064c4841"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WASD"",
                    ""id"": ""8cc632bd-c7fa-4c17-93bb-50455e744cc8"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""8394cebf-703a-40e1-bfb0-155096a502ce"",
                    ""path"": ""<Keyboard>/o"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""f53889df-060e-4193-935b-2fc7d920bb22"",
                    ""path"": ""<Keyboard>/l"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""0c268e95-5e68-4104-a3ad-81fff959a979"",
                    ""path"": ""<Keyboard>/k"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""8d351d0a-a595-4310-b7d6-be386d781207"",
                    ""path"": ""<Keyboard>/semicolon"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""7ed6b4e1-33f9-4aaa-9d19-fe66d5b5975b"",
                    ""path"": ""<Keyboard>/n"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Attack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""KeyboardLeft"",
            ""bindingGroup"": ""KeyboardLeft"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""KeyboardRight"",
            ""bindingGroup"": ""KeyboardRight"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
            // KeyboardLeft
            m_KeyboardLeft = asset.FindActionMap("KeyboardLeft", throwIfNotFound: true);
            m_KeyboardLeft_Move = m_KeyboardLeft.FindAction("Move", throwIfNotFound: true);
            m_KeyboardLeft_Attack = m_KeyboardLeft.FindAction("Attack", throwIfNotFound: true);
        }

        public void Dispose()
        {
            UnityEngine.Object.Destroy(asset);
        }

        public InputBinding? bindingMask
        {
            get => asset.bindingMask;
            set => asset.bindingMask = value;
        }

        public ReadOnlyArray<InputDevice>? devices
        {
            get => asset.devices;
            set => asset.devices = value;
        }

        public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

        public bool Contains(InputAction action)
        {
            return asset.Contains(action);
        }

        public IEnumerator<InputAction> GetEnumerator()
        {
            return asset.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void Enable()
        {
            asset.Enable();
        }

        public void Disable()
        {
            asset.Disable();
        }

        // KeyboardLeft
        private readonly InputActionMap m_KeyboardLeft;
        private IKeyboardLeftActions m_KeyboardLeftActionsCallbackInterface;
        private readonly InputAction m_KeyboardLeft_Move;
        private readonly InputAction m_KeyboardLeft_Attack;
        public struct KeyboardLeftActions
        {
            private @PaddleControls m_Wrapper;
            public KeyboardLeftActions(@PaddleControls wrapper) { m_Wrapper = wrapper; }
            public InputAction @Move => m_Wrapper.m_KeyboardLeft_Move;
            public InputAction @Attack => m_Wrapper.m_KeyboardLeft_Attack;
            public InputActionMap Get() { return m_Wrapper.m_KeyboardLeft; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled => Get().enabled;
            public static implicit operator InputActionMap(KeyboardLeftActions set) { return set.Get(); }
            public void SetCallbacks(IKeyboardLeftActions instance)
            {
                if (m_Wrapper.m_KeyboardLeftActionsCallbackInterface != null)
                {
                    @Move.started -= m_Wrapper.m_KeyboardLeftActionsCallbackInterface.OnMove;
                    @Move.performed -= m_Wrapper.m_KeyboardLeftActionsCallbackInterface.OnMove;
                    @Move.canceled -= m_Wrapper.m_KeyboardLeftActionsCallbackInterface.OnMove;
                    @Attack.started -= m_Wrapper.m_KeyboardLeftActionsCallbackInterface.OnAttack;
                    @Attack.performed -= m_Wrapper.m_KeyboardLeftActionsCallbackInterface.OnAttack;
                    @Attack.canceled -= m_Wrapper.m_KeyboardLeftActionsCallbackInterface.OnAttack;
                }
                m_Wrapper.m_KeyboardLeftActionsCallbackInterface = instance;
                if (instance != null)
                {
                    @Move.started += instance.OnMove;
                    @Move.performed += instance.OnMove;
                    @Move.canceled += instance.OnMove;
                    @Attack.started += instance.OnAttack;
                    @Attack.performed += instance.OnAttack;
                    @Attack.canceled += instance.OnAttack;
                }
            }
        }
        public KeyboardLeftActions @KeyboardLeft => new KeyboardLeftActions(this);
        private int m_KeyboardLeftSchemeIndex = -1;
        public InputControlScheme KeyboardLeftScheme
        {
            get
            {
                if (m_KeyboardLeftSchemeIndex == -1) m_KeyboardLeftSchemeIndex = asset.FindControlSchemeIndex("KeyboardLeft");
                return asset.controlSchemes[m_KeyboardLeftSchemeIndex];
            }
        }
        private int m_KeyboardRightSchemeIndex = -1;
        public InputControlScheme KeyboardRightScheme
        {
            get
            {
                if (m_KeyboardRightSchemeIndex == -1) m_KeyboardRightSchemeIndex = asset.FindControlSchemeIndex("KeyboardRight");
                return asset.controlSchemes[m_KeyboardRightSchemeIndex];
            }
        }
        public interface IKeyboardLeftActions
        {
            void OnMove(InputAction.CallbackContext context);
            void OnAttack(InputAction.CallbackContext context);
        }
    }
}
