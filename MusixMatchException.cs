using System;

namespace jMusixMatchSharp;

/**
 * A custom exception for the MusixMatch.
 *
 * @author Chris Anderson
 * @version 1.0
 */
public class MusixMatchException : Exception
{

    public MusixMatchException(String message) : base(message) {
        
    }

    public MusixMatchException(String message, Exception cause) : base(message, cause) {
        
    }

}
